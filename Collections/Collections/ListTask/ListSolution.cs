using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * As input receive an List of objects of class WebElement
 * (which contains string XPath, string Text, string ClassName, string Name) and another parameter string requiredClassName.
 * Return one string with all Text values of controls where ClassName = requiredClassName separated by ','
 */
namespace Collections.ListTask
{
    public class ListSolution
    {

        public List<WebElement> GenerateData()
        {
            List<WebElement> elements = new List<WebElement>();
            Console.Write("Enter count: ");
            int count = Convert.ToInt32(Console.ReadLine());
            var tmpElement = new WebElement();
            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter Xpath: ");
                string Xpath = Console.ReadLine();
                Console.Write("Enter Text: ");
                string Text = Console.ReadLine();
                Console.Write("Enter Classname: ");
                string ClassName = Console.ReadLine();
                Console.Write("Enter Name: ");
                string Name = Console.ReadLine();
                tmpElement.Xpath = Xpath;
                tmpElement.Text = Text;
                tmpElement.ClassName = ClassName;
                tmpElement.Name = Name;

                elements.Add(tmpElement);
            }
            return elements;
        }

        public string CreateOutput()
        {
            List<WebElement> items = new List<WebElement>();
            items.Add(new WebElement() { ClassName = "CN1", Name = "N1", Xpath = "xpath1", Text = "text1" });
            items.Add(new WebElement() { ClassName = "CN1", Name = "N2", Xpath = "xpath2", Text = "text2" });
            items.Add(new WebElement() { ClassName = "CN1", Name = "N3", Xpath = "xpath3", Text = "text3" });


            Console.Write("Enter requiredClassName: ");
            string requiredClassName = Console.ReadLine();
            var finalResult = "";
            foreach (WebElement el in items)
            {
                if (requiredClassName.Equals(el.ClassName))
                {
                    finalResult = String.Join(el.Text, finalResult, ", ");
                }

            }
            string str = finalResult.Remove(finalResult.LastIndexOf(", "));
            Console.WriteLine(str);
            Console.ReadLine();
            return finalResult;
        }


        public string ListOfElementsLinq()
        {
            var items = GenerateData();
            Console.Write("Enter RequiredClassName: ");
            string requiredClassName = Console.ReadLine();

            var result = from el in items
                         where requiredClassName.Equals(el.ClassName)
                         select el;
            var finalResult = "";
            foreach (WebElement i in result)
            {
                finalResult = String.Join(finalResult, i, ",");
            }
            string str = finalResult.Remove(finalResult.LastIndexOf(", "));
            Console.WriteLine(str);
            Console.ReadLine();
            return finalResult;
        }
    }

}


