using Json;
using Json.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JsonIntegration
{
    class JsonHelpers
    {
        public JsonHelpers(string path)
        {

        }
        
        string readResult = string.Empty;
        string writeResult = string.Empty;
                
            
            public Account GetAccount(string nameAttribute, string path)
            {
               
                return new Account();

            }

           


            public void CreateAccountAttribute()
            {
                /*XmlNode node = doc.CreateNode(XmlNodeType.Element, "Account", null);
                XmlAttribute name = doc.CreateAttribute("name");
                name.Value = "Test";
                XmlNode nodeFirstName = doc.CreateElement("FistName");
                nodeFirstName.InnerText = "Merry";
                node.Attributes.Append(name);
                node.AppendChild(nodeFirstName);
                doc.DocumentElement.AppendChild(node);
                doc.Save("Account.xml");
                doc.Save(Console.Out);
                */
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
        }

        public void EditAndUpdateNode(string path)
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
