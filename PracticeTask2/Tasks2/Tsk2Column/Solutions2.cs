using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeTask2;

namespace Tasks2.Tsk2Column
{
   public class Solutions2:Column
    {
        public void PrintDictionaries(IDictionary<int, string> idsAndNames, IDictionary<string, string> namesAndHeaders)
        {
            idsAndNames.Add(Id,Name);
            namesAndHeaders.Add(Name, Header);

            foreach (KeyValuePair<int, string> keyValue in idsAndNames)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            foreach (KeyValuePair<string, string> keyValue in namesAndHeaders)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            
        }
    }
}
