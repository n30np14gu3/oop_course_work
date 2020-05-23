namespace oop_sdk.net
{

    /// <summary>
    /// Перечисление, которое описывает коды методов для запроса и ответов от сервера
    /// </summary>
    public enum RequestMethods
    {
        /// <summary>
        /// Метод отправки настроек (вызывается только один раз)
        /// </summary>
        RequestSendSettings = 0,

        /// <summary>
        /// Метод запуска симуляции
        /// </summary>
        RequestStartEmulation,
        
        /// <summary>
        /// Метод остановки симуляции
        /// </summary>
        RequestStopEmulation,

        /// <summary>
        /// Событие, которое отправляется при смене статуса ТУ
        /// </summary>
        EmulationEntityEvent = 100,

        /// <summary>
        /// Событие, которое отправляется каждый час симуляции
        /// </summary>
        EmulationEventHourTick,

        /// <summary>
        /// Событие, которо отправляется каждый день симуляции
        /// </summary>
        EmulationEventNewDay,

        /// <summary>
        /// Событие, которое отправляется, когда симуляция остановлена / запущена
        /// </summary>
        EmulationStatus
    }
}