using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Pages01;

namespace Tests01
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        // IWebDriver driver;
        public void TestApp()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://www.demoqa.com";
            driver.Close();
        }



    }
}
