using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * There is a class called Column(which contains int Id, string Name,
 * string Header). As an input receive two dictionaries idsAndNames
 * <int, string> and namesAndHeaders<string, string>.We know that in first
 * dictionary key int represents a Id of column, and value string represents NameAnd for 
 * second dictionary key string is a Name and value string represents Header.
 * Output the Column objects with all known data using the input dictionaries
 */

namespace Collections.ColumnTask
{

    public class ColumnOutput
    {
        public void PrintDictionariesFE()
        {
            Dictionary<int, string> idsAndName = new Dictionary<int, string>()
            {
                {1, "Name1" },
                {2, "Name2" },
                {3, "Name3" },
                {4, "Name4" }
            };

            Dictionary<string, string> namesAndHeaders = new Dictionary<string, string>()
            {
                {"Name1", "Header1" },
                {"Name2", "Header2" },
                {"Name3", "Header3" },
                {"Name4", "Header4" },
            };

            foreach (KeyValuePair<int, string> keyValue in idsAndName)
            {
                var header = namesAndHeaders[keyValue.Value];
                int id = keyValue.Key;
                string name = keyValue.Value;

                Column col = new Column() { Header = header, Id = id, Name = name };
                Console.WriteLine(col);
            }
            Console.ReadLine();

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

