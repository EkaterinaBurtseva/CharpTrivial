using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Task1_methods
{
    public class Features
    {
        public void ReadNodeXpath()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("example.xml");
            XmlNodeList nodeList = doc.SelectNodes("/bookstore/book[@publicationdate='1981']/title");            
            foreach (XmlNode node in nodeList)
            {
                Console.WriteLine(node.InnerText);
               // Console.WriteLine("First-name: " + node["first-name"].InnerText + " Last Name: " + node["last-name"].InnerText);
            }
                      

        }
           public  void ReadValueByXpath()
            {
            XmlDocument doc = new XmlDocument();
            doc.Load("example.xml");
            string myVal = ((XmlElement)doc.DocumentElement.SelectSingleNode("descendant::bookstore/book/author/xpath")).Value;
            Console.WriteLine(myVal);

        }

        public void AddNodeByXpath()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("example.xml");
            XmlNode node = doc.CreateNode(XmlNodeType.Element, "book", null);
            XmlNode nodeTitle = doc.CreateElement("title");
            nodeTitle.InnerText = "This title is created by code";
            XmlNode nodeUrl = doc.CreateElement("author");
            node.AppendChild(nodeTitle);
            node.AppendChild(nodeUrl);
            doc.DocumentElement.AppendChild(node);
            doc.Save("example.xml");

        }

        public void ModifyValueByXpath()
        {

        }
        }
    }

