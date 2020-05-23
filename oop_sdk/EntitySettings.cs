namespace oop_sdk
{
    /// <summary>
    /// Класс, описывающий настройки ТУ
    /// </summary>
    public class EntitySettings
    {
        /// <summary>
        /// Кол-во отказов в сутки
        /// </summary>
        public int Z;


        /// <summary>
        /// Мат ожидание времени восстановления
        /// </summary>
        public int R;

        public EntitySettings Clone()
        {
            return new EntitySettings
            {
                Z = Z,
                R = R
            };
        }
    }
}