using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JsonIntegration
{
    public class DataJsonUpdating
    {
        private static string path = "C:\\Users\\kate\\Desktop\\Accounts2.json";

        static void Main(string[] args)
        {
            JsonHelpers jsonData = new JsonHelpers(path);
            // jsonData.EditAndUpdateNode(path);       
            jsonData.AddNewNode(path, "LoginName");
            Console.ReadLine();
        }
    }
}
