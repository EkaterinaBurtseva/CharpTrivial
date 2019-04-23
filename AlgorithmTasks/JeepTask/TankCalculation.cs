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
            Console.WriteLine("Enter distance");
            int distance = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter tank volume");
            int tank = Convert.ToInt32(Console.ReadLine());
            if (distance < 0 && distance <= 5 * tank && distance > 32000)
            {
                Console.WriteLine("Entered value n is wrong. Please try again");

            }
            int result = 0;
            int passWay = 0;
            int stations = 0;

            while (passWay <= distance)
            {
                stations++;
                passWay += tank / (2 * stations - 1);
            }

            stations--;
            passWay = 0;

            for (int i = 1; i <= stations; i++)
                passWay += tank / (2 * i - 1);
            double spentFuel = stations * tank;


            int restOfDistance = distance - passWay;
            result += restOfDistance * (2 * stations + 1);

            Console.WriteLine($"Minimum count of fuel to cross the desert is {result}");
        }
    }
}

