namespace oop_sdk
{
    /// <summary>
    /// Класс, описывающий ТУ
    /// </summary>
    public class Entity
    {
        public int Id;

        /// <summary>
        /// Настройки ТУ
        /// </summary>
        public EntitySettings Settings;

        /// <summary>
        /// Статус устройства
        /// </summary>
        public EntityStatus Status;


        /// <summary>
        /// Сколько дней прошло с момента начала ремонта
        /// </summary>
        internal int DaysInFix;

    }
}