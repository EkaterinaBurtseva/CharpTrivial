using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeepTask
{
    /*Наш джип находится в пустыне и должен достичь точки, находящейся на расстоянии N километров от него.
     * Рельеф сложный, машина старая, и похоже, что топливо вытекает, так что на каждый пройденный машиной километр 
     * тратится один литр топлива.В джипе есть канистры, общая ёмкость которых вместе с бензобаком составляет M литров (M<N).
     * В начале дороги есть неограниченное количество топлива, а повсюду в пустыне есть пустые цистерны, в которых джип, проезжая, может оставить неограниченное количество топлива.

        Напишите программу, которая находит минимальное количество топлива в литрах, которое необходимо для достижения заданной точки 
        Исходные данные Два целых числа, N и M.Известно, что 5M ≥ N > 0 и N < 32000.
        Результат:В единственной строке выведите минимальное количество литров топлива, округлённое вверх.
     */
    class TankCalculation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n");
            int n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter m");
            int m = Convert.ToInt32(Console.ReadLine());
            if (n < 0 && n <= 5m && n > 32000)
            {
                Console.WriteLine("Entered value n is wrong. Please try again");

            }
            int result = m;
            int[] way = new int[n];
            int[] gas = new int[n];
            way[1] = m;
            gas[1] = m;
            int k = 2;
            while (way[k - 1] + m / (2 * k - 1) < n)
            {
                way[k] = way[k - 1] + m / (2 * k - 1);
                gas[k] = k * m;
                k++;
                }
            result = (n - way[k - 1])*(2 * k - 1) + gas[k - 1];
            if (result < 1e-8)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(result + 1);
            }
        }
        
    }
}

