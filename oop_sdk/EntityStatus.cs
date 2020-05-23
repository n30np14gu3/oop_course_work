namespace oop_sdk
{
    /// <summary>
    /// Перечисление описывает статусы ТУ
    /// </summary>
    public enum EntityStatus
    {
        /// <summary>
        /// Устройство сломано
        /// </summary>
        EntityBroken = 0,

        /// <summary>
        /// Устройство в процессе починки
        /// </summary>
        EntityInRepairing,

        /// <summary>
        /// Устройство починено
        /// </summary>
        EntityFixed
    }
}