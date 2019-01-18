using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JsonIntegration
{
    class JsonHelpers
    {
        public JsonHelpers(string path)
        {

        }

        string readResult = string.Empty;
        string writeResult = string.Empty;

        public Account GetAccount(string path, string parameter, string parameterName)
        {
            using (StreamReader r = new StreamReader(path))
            {
                var json = r.ReadToEnd();
                JArray jobj = JArray.Parse(json);
                var token = $"$.[?(@" + parameter + "== '" + parameterName + "')]";
                JToken accountData = jobj.SelectToken(token);
                Console.WriteLine(accountData);

                return new Account();

            }

        }

        public void UpdateAccount(Account account, string path)
        {
            Console.WriteLine("updating...");
            string json = File.ReadAllText(path);
            string jsonData = JsonConvert.SerializeObject(account, Formatting.Indented);
            Console.WriteLine(jsonData);
        }

        public void AddNewNode(string path, string newNode)
        {
                       
        }

        public void EditAndUpdateNode(string path, string old = "Kate", string newValue = "T")
        {
            using (StreamReader r = new StreamReader(path))
            {
                var json = r.ReadToEnd();
                var jobj = JObject.Parse(json);
                readResult = jobj.ToString();
                foreach (var item in jobj.Properties())
                {
                    item.Value = item.Value.ToString().Replace("Kate", "Katyusha");
                }
                writeResult = jobj.ToString();
                Console.WriteLine(jobj);
            }
            Console.WriteLine(readResult);
            File.WriteAllText(path, writeResult);
        }
    }
}
