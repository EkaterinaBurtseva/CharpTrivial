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

            foreach (var letter in enteredValue.Distinct().ToArray())
            {
                var count = enteredValue.Count(chr => chr == letter);
                Console.WriteLine("Number of characters {0} = {1}", letter, count);
                //TODO: Add to dictionary
            }
            Console.ReadLine();

            //NumberCalculation(enteredValue);
            var test = CountLetters(enteredValue);
        }

        public static void NumberCalculation(string enteredString)
        {
            int count = 0;
            char prevValue = '&';
            foreach (char c in enteredString.Distinct())
            {
                foreach (char ch in enteredString)
                {
                    if (ch == c && ch != prevValue)
                    {
                        count++;
                    }
                }
                if (count != 0)
                {
                    Console.WriteLine("Variant2: Number of characters {0} = {1}", c, count);
                    count = 0;
                    prevValue = c;
                }

            }

            Console.ReadLine();
        }
        public static Dictionary <char, int> CountLetters(string enteredString)
        {
            Dictionary<char, int> results = new Dictionary<char, int>();
            foreach(char c in enteredString)
            {
                if (results.Keys.Contains(c))
                {
                    results[c] ++;
                }
                else
                {
                    results.Add(c,1);
                }
            }

            return results;
        }
    }
}

