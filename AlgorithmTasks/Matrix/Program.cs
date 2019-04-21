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

            int[,] array = GenerateMatrix(matrixRow, minValue, maxValue);
            var sumDiagonals = CalculateSumOfDiagonals(array, matrixRow);
            Console.WriteLine("Matrix with switched diagonals");
            int[,] newArray = ReplaceDiagonals(array, matrixRow);
            Console.WriteLine("Transposition Matrix");
            int[,] transArray = TranspMatrixAdditionalMatrix(array, matrixRow);
            int[,] transArray2 = TranspMatrixWithoutAdditionalMatrix(array, matrixRow);
            Console.ReadLine();

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

        public static int CalculateSumOfDiagonals(int[,] array, int n)
        {
            int mainDiagonalSum = 0;
            int sideDiagonalSum = 0;

            for (int i = 0; i <= n - 1; i++)
            {

                mainDiagonalSum += array[i, i];
                sideDiagonalSum += array[i, n - i - 1];
            }


            Console.WriteLine($"Sum of diagonals {mainDiagonalSum + sideDiagonalSum}");
            return mainDiagonalSum + sideDiagonalSum;
        }
        public static int[,] ReplaceDiagonals(int[,] array, int n)
        {
            int tmp = 0;

            for (int i = 0; i < n; i++)
            {
                tmp = array[i, i];
                array[i, i] = array[i, n - i - 1];
                array[i, n - i - 1] = tmp;
            }

            for (int i = 0; i < n; i++)
            {

                Console.Write(" {0}", array[i, i]);
            }
            Console.WriteLine();
            Console.ReadLine();

            return array;
        }
        public static int[,] TranspMatrixAdditionalMatrix(int[,] array, int n)
        {
            int[,] trans = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    trans[i, j] = array[j, i];
                    Console.Write(trans[i, j] + " ");
                }
                Console.WriteLine();
            }
            return trans;
        }

        public static int[,] TranspMatrixWithoutAdditionalMatrix(int[,] array, int n)
        {
            int tmp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    tmp = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = tmp;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" {0}", array[i, j]);
                }
                Console.WriteLine();
            }

            return array;
        }
    }
}
