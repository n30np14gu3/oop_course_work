namespace oop_sdk.net
{
    /// <summary>
    /// Базовый класс ответа от сервера, наследуется от BaseRequest
    /// </summary>
    /// <typeparam name="T">Тип данных в ответе</typeparam>
    public class BaseResponse<T> : BaseRequest<T>
    {
        /// <summary>
        /// Флаг ошибки (1 - если ошибка есть / 0 - если нет)
        /// </summary>
        public int error;

        /// <summary>
        /// Сообщение об ошибке (если надо)
        /// </summary>
        public string message;
    }
}