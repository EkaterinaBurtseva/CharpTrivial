using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeTask2;

/*
 * There is a class called Column (which contains int Id, string Name,
 * string Header). As an input receive two dictionaries idsAndNames
 * <int, string> and namesAndHeaders <string, string>. We know that in first
 * dictionary key int represents a Id of column, and value string represents NameAnd for 
 * second dictionary key string is a Name and value string represents Header. 
 * Outpit the Column objects with all known data using the input dictionaries
 */
namespace Tasks2.Tsk2Column
{
    public class Solutions2

    {
        public string PrintDictionariesFE(IDictionary<int, string> idsAndNames, IDictionary<string, string> namesAndHeaders)
        {
            Console.Write("Enter Id: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Header: ");
            string Header = Console.ReadLine();


            idsAndNames.Add(Id, Name);
            namesAndHeaders.Add(Name, Header);

            var result1 = "error";
            var result2 = "error2";

            foreach (KeyValuePair<int, string> keyValue in idsAndNames)
            {
                result1 = keyValue.Key + " - " + keyValue.Value;
                Console.WriteLine(result1);
            }

            foreach (KeyValuePair<string, string> keyValue in namesAndHeaders)
            {
                result2 = keyValue.Key + " - " + keyValue.Value;
                Console.WriteLine(result2);
            }
            Console.WriteLine(result1 + " | " + result2);
            return result1 + " | " + result2;
        }



        public string PrintDictionariesLNQ()
        {
            Console.Write("Enter Id: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter Header: ");
            string Header = Console.ReadLine();

            Dictionary<int, string> idsAndNames = new Dictionary<int, string>();
            Dictionary<string, string> namesAndHeaders = new Dictionary<string, string>();

            idsAndNames.Add(Id, Name);
            namesAndHeaders.Add(Name, Header);

            var result1 = "error";
            var result2 = "error2";


            /* var query1 =
            (from keyValue in namesAndHeaders
             select new { keyValue.Key, keyValue.Value })
            .Union(
            from keyValue in idsAndNames
            select new { keyValue.Key, keyValue.Value };
            */
            var query1 =
            from key in namesAndHeaders
            select key;

            var query2 =
           from key in idsAndNames
           select key;

            foreach (KeyValuePair<string, string> key in query1)
            {
                result2 = key.Key + " - " + key.Value;
                Console.WriteLine(result1);
            }

            foreach (KeyValuePair<int, string> key in query2)
            {
                result2 = key.Key + " - " + key.Value;
                Console.WriteLine(result2);
            }

            Console.WriteLine(result1 + " | " + result2);
            return result1 + " | " + result2;

        }
    }
}
