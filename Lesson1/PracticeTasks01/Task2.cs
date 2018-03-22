using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PracticeTasks01
{
    class Task2
    {
        static void Main(string[] args)
        {
            
            Divide(5, 0);
            
        }
        public static double Divide(double x, double y) {
            
            double result = 0;
            try
            {
                result = x / y;

                if (Double.IsInfinity(result))
                {
                    throw new DivideByZeroException("zero");
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
            catch (ArithmeticException arife)
            {
                Console.WriteLine(arife.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong type " + e.Message);
            }
            return result;
        }
            
    }
}
