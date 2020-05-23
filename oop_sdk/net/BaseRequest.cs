namespace oop_sdk.net
{
    /// <summary>
    /// Класс, описывающий базовый шаблон  запроса к серверу
    /// </summary>
    /// <typeparam name="T">Тип данных для запроса</typeparam>
    public class BaseRequest<T>
    {
        /// <summary>
        /// Метод запроса
        /// </summary>
        public RequestMethods method;

        /// <summary>
        /// Данные запроса
        /// </summary>
        public T data;
    }
}