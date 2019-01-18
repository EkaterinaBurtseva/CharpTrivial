using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonIntegration
{
    public class DataJsonUpdating
    {
        private static string path = "C:\\Users\\kateryna.burtseva\\Documents\\CharpTrivial\\DataIntegration\\JsonIntegration\\Accounts1.json";

        static void Main(string[] args)
        {
            JsonHelpers jsonData = new JsonHelpers(path);

            Account KateAccount = jsonData.GetAccount(path, "AccountName", "Katerina");
            KateAccount.FirstName = "Kate1";
            jsonData.UpdateAccount(KateAccount, path);
            Console.ReadLine();
        }
    }
}
