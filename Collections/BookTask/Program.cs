using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> book = new Dictionary<string, string>()
            {
                { "test", "test2" } ,
              
            };
            foreach (KeyValuePair<string, string> keyValue in book)
            {
               
                string bookName = keyValue.Key;
                string bookAuthor = keyValue.Value;

                Book col = new Book() { BookName = bookName, BookAuthor = bookAuthor};
                Console.WriteLine(col);
            }
            book.Add("testinh", "tsgjghj");
            Console.ReadLine();
        }
    }
}
