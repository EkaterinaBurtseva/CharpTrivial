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
            int[,] transArray = TranspMatrix(array, matrixRow);
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

                for (int j = 0; j <= n - 1; j++)
                {
                    if (i == j)
                    {
                        mainDiagonalSum += array[i, j];
                        sideDiagonalSum += array[i, n - j - 1];
                    }


                }
            }
            Console.WriteLine($"Sum of diagonals {mainDiagonalSum + sideDiagonalSum}");
            return mainDiagonalSum + sideDiagonalSum;
        }
        public static int[,] ReplaceDiagonals(int[,] array, int n)
        {
            int[,] newArray = new int[n, n];
            int[] mainDiagonal = new int[n];
            int[] sideDiagonal = new int[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        mainDiagonal[i] = array[i, j];
                    }
                    if (i == n - 1 - j)
                    {
                        sideDiagonal[i] = array[i, j];
                    }
                }
            }


            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {

                    newArray[i, j] = array[i, j];

                    if (i == n - 1 - j)
                        newArray[i, j] = mainDiagonal[i];

                    if (i == j)
                        newArray[i, j] = sideDiagonal[i];


                }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    Console.Write(newArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            return newArray;
        }
        public static int[,] TranspMatrix(int[,] array, int n)
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
    }
}
