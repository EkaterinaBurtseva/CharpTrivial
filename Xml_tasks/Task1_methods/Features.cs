using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Task1
{
    public class Features
    {
        private XmlDocument doc;

        public Features(/*path*/)
        {
            this.doc = new XmlDocument();
            doc.Load("example.xml");
        }

        public void ReadNodeXpath()
        {

            XmlNodeList nodeList = doc.SelectNodes("/bookstore/book[@publicationdate='1981']/title");
            foreach (XmlNode node in nodeList)
            {
                Console.WriteLine(node.InnerText);
                // Console.WriteLine("First-name: " + node["first-name"].InnerText + " Last Name: " + node["last-name"].InnerText);
            }


        }
        public void ReadValueByXpath()
        {
            XmlNodeList nodeList = doc.DocumentElement.SelectNodes("/bookstore/book[@publicationdate='1967']");
            string myVal = "";
            foreach (XmlNode node in nodeList)
            {
                myVal = node.Attributes["genre"].Value.ToString();
                Console.WriteLine(myVal);

            }
        }

        public void AddNodeByXpath()
        {
            XmlNode node = doc.CreateNode(XmlNodeType.Element, "book", null);

            XmlAttribute genre = doc.CreateAttribute("genre");
            genre.Value = "detective";
            XmlAttribute publicationdate = doc.CreateAttribute("publicationdate");
            publicationdate.Value = "2000";
            XmlAttribute isbn = doc.CreateAttribute("ISBN");
            isbn.Value = "0-861001-77-6";

            XmlNode nodeTitle = doc.CreateElement("title");
            nodeTitle.InnerText = "Snowman";
            XmlNode nodeAuthor = doc.CreateElement("author");
            nodeAuthor.InnerText = "Jo Nesbø";

            node.Attributes.Append(genre);
            node.Attributes.Append(publicationdate);
            node.Attributes.Append(isbn);

            node.AppendChild(nodeTitle);
            node.AppendChild(nodeAuthor);
            doc.DocumentElement.AppendChild(node);
            doc.Save("example.xml");
            doc.Save(Console.Out);

        }

        public void ModifyValueByXpath()
        {
            XmlNode node = doc.SelectSingleNode("bookstore/book[@publicationdate='2000']/author");
            node.InnerText = "Vasya Pupkin";
            doc.Save("example.xml");
            doc.Save(Console.Out);
        }
    }
}

