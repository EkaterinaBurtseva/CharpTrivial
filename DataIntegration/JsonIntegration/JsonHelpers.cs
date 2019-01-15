using Newtonsoft.Json.Linq;
using System;
using System.IO;


namespace JsonIntegration
{
    class JsonHelpers
    {
        public JsonHelpers(string path)
        {

        }
        
        string readResult = string.Empty;
        string writeResult = string.Empty;
                
            

            public void CreateAccountAttribute(string path)
            {
            using (StreamReader r = new StreamReader(path))
            {
                var json = r.ReadToEnd();
                JObject test = new JObject("test",
                new JObject(
                    new JProperty("test1", "test2")));
                
            }
            //create new parameter in account
            }

        public Account GetAccount(string path, string accountName)
        {
            using (StreamReader r = new StreamReader(path))
            {
                var json = r.ReadToEnd();
                JArray jobj = JArray.Parse(json);
                // dynamic data = JObject.Parse(jobj[0].ToString());
                // foreach(var item in accountNa)
                JToken accountData = jobj.SelectToken("$.[?(@AccountName=='Katerina' )]");
               
                  
                Console.WriteLine(accountData);

                return new Account();

            }
           
}

        public void AddNewNode(string path, string newNode)
        {
            using (StreamReader r = new StreamReader(path))
            {
                var json = r.ReadToEnd();
                var jobj = JObject.Parse(json);                
                jobj.Add(newNode, JObject.FromObject(jobj));
              
                Console.WriteLine(json);
                
            }

            //var list = JsonConvert.DeserializeObject<List<Account>>(myJsonString);
           // list.Add(new Account(1234, "carl2");
            //var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);
        }

        public void EditAndUpdateNode(string path, string old = "Kate", string newValue ="T")
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
