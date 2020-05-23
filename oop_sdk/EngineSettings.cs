namespace oop_sdk
{
    /// <summary>
    /// Класс, описывающий настройки ТУ, а также доп настройки
    /// 
    /// </summary>
    public class EngineSettings
    {
        /// <summary>
        /// Кол-во едениц ТУ
        /// </summary>
        public int N;


        /// <summary>
        /// Кол-во технологических линий
        /// </summary>
        public int M;


        /// <summary>
        /// Максимальное кол-во ТУ на линии
        /// </summary>
        public int L;

        /// <summary>
        /// Время одного часа симуляции
        /// </summary>
        public int HourTime;
    }
}