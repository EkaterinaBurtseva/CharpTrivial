using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Accounts
{
    public class Methods
    {
        private XmlDocument doc;

        public Methods(/*path*/)
        {
            this.doc = new XmlDocument();
            doc.Load("Account.xml");
        }


        public void CreateAccountAttribute()
        {
            XmlNode node = doc.CreateNode(XmlNodeType.Element, "Account", null);
            XmlAttribute name = doc.CreateAttribute("name");
            name.Value = "Test";
            XmlNode nodeFirstName = doc.CreateElement("FistName");
            nodeFirstName.InnerText = "Merry";
            node.Attributes.Append(name);
            node.AppendChild(nodeFirstName);
            doc.DocumentElement.AppendChild(node);
            doc.Save("Account.xml");
            doc.Save(Console.Out);
        }

        public void EditAndAddNewNode()
        {
            XmlNode node = doc.SelectSingleNode("Accounts/Account[@name='Katerina']");
            XmlNode job = doc.CreateNode(XmlNodeType.Element, "Job", null);
            node.AppendChild(job);
            doc.DocumentElement.AppendChild(node);
            job.InnerText = "QA";
            doc.Save("Account.xml");
            doc.Save(Console.Out);
        }

        public void EditAndUpdateNode()
        {
            XmlNode node = doc.SelectSingleNode("Accounts/Account[@name='Katerina']/Job");
            node.InnerText = "Software Developer";
            doc.Save("Account.xml");
            doc.Save(Console.Out);
        }
    }
}
