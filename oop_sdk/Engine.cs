using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace oop_sdk
{
    /// <summary>
    /// Класс, описывающий симуляцию на производстве
    /// </summary>
    public class Engine
    {
        //Настройки предприятия
        private EngineSettings _engineSettings;

        //Настройки ТУ по умолчанию
        private EntitySettings _entitySettings;

        //Список ТУ
        private List<Entity> _entityList;

        //Список технологических линий
        private List<Queue<Entity>> _fixingLines;


        public delegate void EntityCallback(int entityId, EntityStatus status);

        public delegate void EngineCallback(bool engineStatus);

        public delegate void NewDayCallback(int totalDays);
        public delegate void HourTickCallback(int currentHour);

        public event EngineCallback OnStatusChanged;

        public event EntityCallback OnEntityChanged;

        public event NewDayCallback OnNewDay;
        public event HourTickCallback OnHourTick;

        public int TotalDays { get; private set; }

        public int CurrentHour { get; private set; }

        public bool EngineStatus { get; private set; }

        /// <summary>
        /// Меод для получения списка ТУ
        /// </summary>
        /// <returns>Список ТУ</returns>
        public List<Entity> GetEntities()
        {
            return _entityList;
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="engineSettings">Настройки предприятия</param>
        /// <param name="entitySettings">Настройки ТУ</param>
        public Engine(EngineSettings engineSettings, EntitySettings entitySettings)
        {
            _engineSettings = engineSettings;
            _entitySettings = entitySettings;

            _entityList = new List<Entity>();
            for (int i = 0; i < _engineSettings.N; i++)
            {
                _entityList.Add(new Entity
                {
                    Id = i,
                    DaysInFix = 0,
                    Status = EntityStatus.EntityFixed,
                    Settings = entitySettings.Clone()
                });
            }

            _fixingLines = Enumerable.Range(0, _engineSettings.M).Select(x => new Queue<Entity>()).ToList();

            TotalDays = 0;
            CurrentHour = 0;

        }

        /// <summary>
        /// Запуск эмуляции
        /// </summary>
        public async void Start()
        {
            EngineStatus = true;
            OnStatusChanged?.Invoke(EngineStatus);

            await Task.Run(() =>
            {

                bool _newDay = true;

                while (EngineStatus)
                {

                    //Если не прошел день, то эмулируем его
                    if (CurrentHour < 24)
                    {

                        //Обрабатываем ТУ
                        _entityList.Each((e, id) =>
                        {
                            //Если это первый цикл дня, то надо сбросить Кол-во отказов
                            if (_newDay)
                            {
                                e.Settings.Z = _entitySettings.Z;
                            }

                            //Если ТУ в процессе починки, то пропускаем его
                            if (e.Status == EntityStatus.EntityInRepairing)
                                goto each_cont;

                            //Если устройство сломано, то ищем, линию, на которой есть свободное место
                            if (e.Status == EntityStatus.EntityBroken)
                            {
                                tryFix();
                                goto each_cont;
                            }

                            //Если с устройством все норм, то смотрим, можно ли его сломать


                            //Если устройство сломалось, то пытаемся его починить
                            if (MathTools.GetChance(e.Settings.Z / 24m))
                            {
                                //Уменьшаем вероятность отказа (также ограничиваем снизу)
                                e.Settings.Z--;
                                if (e.Settings.Z <= 0)
                                    e.Settings.Z = 0;

                                e.Status = EntityStatus.EntityBroken;
                                OnEntityChanged?.Invoke(id, e.Status);
                                tryFix();
                            }

                            each_cont: ;

                            //Вложенный метод, для попытки отправить ТУ на починку
                            void tryFix()
                            {
                                var line = _fixingLines.Where(x => x.Count < _engineSettings.L).OrderBy(x => x.Count).FirstOrDefault();
                                if (line != null)
                                {
                                    e.Status = EntityStatus.EntityInRepairing;
                                    line.Enqueue(e);
                                    OnEntityChanged?.Invoke(id, e.Status);
                                }
                            }
                        });

                        foreach (Queue<Entity> q in _fixingLines)
                        {
                            //Если линия пуста, то пропускаем ее
                            if(q.Count == 0)
                                continue;

                            //Берем первое ТУ и смотрим, можно ли его починить
                            var e = q.Peek();

                            //Есил починить можно
                            if (MathTools.GetChance((decimal) MathTools.Qt(e.DaysInFix, MathTools.Lambda(e.Settings.R))))
                            {
                                //Обнуляем кол-во дней, которое было потрачено на ремонт
                                e.DaysInFix = 0;

                                //Ставим статус нужный
                                e.Status = EntityStatus.EntityFixed;

                                //Убираем ТУ с очереди
                                q.Dequeue();
                                OnEntityChanged?.Invoke(e.Id, e.Status);
                            }
                        }

                        _newDay = false;
                        OnHourTick?.Invoke(CurrentHour);
                        CurrentHour++;
                        Thread.Sleep(_engineSettings.HourTime);//Один час симуляции
                    }
                    else
                    {
                        //Увеличиваем у каждого время починки (у тех, которые чинятся)
                        foreach (Entity e in _entityList)
                        {
                            if(e.Status != EntityStatus.EntityInRepairing)
                                continue;

                            e.DaysInFix++;
                        }
                        CurrentHour = 0;
                        TotalDays++;
                        _newDay = false;
                        OnNewDay?.Invoke(TotalDays);
                    }
                }

                OnStatusChanged?.Invoke(EngineStatus);
            });

        }


        /// <summary>
        /// Остановка эмуляции
        /// </summary>
        public void Stop()
        {
            EngineStatus = false;
        }
    }
}