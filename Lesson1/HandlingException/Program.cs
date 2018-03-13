using System;
using System.IO;

namespace HandlingException
{
    class Program
    {
        static void Main(string[] args)
        {
            ExceptionTest();
        }
        public static void ExceptionTest()
        {
            StreamReader sr = null;
            try
            {
                sr = File.OpenText(@"c:\data.txt");
                Console.WriteLine(sr.ReadToEnd());
                            }
            catch(FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
                }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
