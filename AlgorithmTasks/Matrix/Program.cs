using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To generate matrix enter n");
            string n = Console.ReadLine();
            int matrixRow = Convert.ToInt32(n);
            Console.WriteLine("Enter minimum number at matrix");
            string min = Console.ReadLine();
            int minValue = Convert.ToInt32(min);
            Console.WriteLine("Enter max number at matrix");
            string max = Console.ReadLine();
            int maxValue = Convert.ToInt32(max);
            GenerateMatrix(matrixRow, minValue, maxValue);

        }


        public static int[,] GenerateMatrix(int matrixRow, int minValue, int maxValue)
        {
            System.Random random = new System.Random();
            int[,] array = new int[matrixRow, matrixRow];

            for (int i = 0; i < matrixRow; i++)
            {
                for (int j = 0; j < matrixRow; j++)
                {
                    array[i, j] = random.Next(minValue, maxValue);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            return array;
        }
        //    public void CalculateSumOfDiagonals()
        // {
        //    long result = 0;
        //   for (int i = 0; i < matrixRow; i++)
        //  {
        //     result += array[i][j];
        //     if (i < matrixRow - 1)
        //          result += array[i][j + 1];
        //   }
        //  }
    }
}
