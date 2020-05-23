using System;
using System.Linq;
using System.Security.Cryptography;

namespace oop_sdk
{
    /// <summary>
    /// Класс нужен для математических рассчетов распределения
    /// </summary>
    public static class MathTools
    {
        /// <summary>
        /// Q(t) = вероятность того, что изделие откажет к моменту времени t.
        /// </summary>
        /// <param name="t">Время T к которому откажет оборудование</param>
        /// <param name="lambda">Среднее число за еденицу времени (рассчет из мат ожидания M=1/lambda)</param>
        /// <returns>Вероятность отказа</returns>
        public static double Qt(double t, double lambda)
        {
            return 1 - Math.Exp((lambda * -1) * t);
        }

        /// <summary>
        /// P(t) = вероятность того, что изделие проработает без отказа от момента t0=0 до момента времени t.
        /// </summary>
        /// <param name="t">Время, до которого будет работать устройство без отказа</param>
        /// <param name="lambda">Среднее число за еденицу времени (рассчет из мат ожидания M=1/lambda)</param>
        /// <returns>Вероятность отказа</returns>
        public static double Pt(double t, double lambda)
        {
            return 1 - Qt(t, lambda);
        }


        /// <summary>
        /// Рассчет среднего числа значений за еденицу времени через мат ожидание
        /// </summary>
        /// <param name="m">Мат ожидание</param>
        /// <returns>Среднее число отказов</returns>
        public static double Lambda(decimal m)
        {
            if (m == 0)
                return 0;

            return (double)(1 / m);
        }


        /// <summary>
        /// Определение случайного события
        /// </summary>
        /// <param name="chanceRate">Вероятность случайного события</param>
        /// <returns>Вернет true, если событие произошло</returns>
        public static bool GetChance(decimal chanceRate)
        {
            chanceRate *= 100;
            using (RandomNumberGenerator rng = new RNGCryptoServiceProvider())
            {
                byte[] rndLayer = new byte[64];
                rng.GetNonZeroBytes(rndLayer);
                int randNum = rndLayer.Sum(x => x) % 100;
                return randNum <= chanceRate;
            }

        }
    }
}