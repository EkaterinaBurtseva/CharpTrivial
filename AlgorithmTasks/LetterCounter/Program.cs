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
            Dictionary<char, int> results = new Dictionary<char, int>();
            foreach (var letter in enteredValue.Distinct().ToArray())
            {
                var count = enteredValue.Count(chr => chr == letter);
                results.Add(letter, count);

            }

            foreach (KeyValuePair<char, int> kvp in results)
            {
                Console.WriteLine("Letter = {0}, Count = {1}", kvp.Key, kvp.Value);
            }
            Console.ReadLine();

            NumberCalculation(enteredValue);
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
        public static Dictionary<char, int> CountLetters(string enteredString)
        {
            Dictionary<char, int> results = new Dictionary<char, int>();
            foreach (char c in enteredString)
            {
                if (results.Keys.Contains(c))
                {
                    results[c]++;
                }
                else
                {
                    results.Add(c, 1);
                }
            }

            return results;
        }
    }
}

