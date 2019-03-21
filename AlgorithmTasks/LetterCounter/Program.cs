using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string enteredValue = Console.ReadLine();
            Console.WriteLine("Enter a character");
            string enteredCharacter = Console.ReadLine();           
            GetCharOccurence(enteredValue, Convert.ToChar(enteredCharacter));
            Console.ReadLine();
        }

        public static int GetCharOccurence(string text, char c)
        {
            int count = text.Where(x => x == c).Count();
            Console.WriteLine($"Symbol {c} repeats {count} times");
            return count;
        }
    }
}
