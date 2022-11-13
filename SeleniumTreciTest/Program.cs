using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTreciTest
{
    public class Program
    {
        IWebDriver drive = new ChromeDriver();
        static void Main(string[] args)
        {



        }
        [SetUp]
        public void Inicijalizacija()
        {
            drive.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            drive.Manage().Window.Maximize();
        }
        [Test]

        public void Test1()
        {
            IWebElement firstName = drive.FindElement(By.Id("firstName"));
            firstName.SendKeys("Zika");

            IWebElement lastName = drive.FindElement(By.Id("lastName"));
            lastName.SendKeys("Spiric");

            IWebElement email = drive.FindElement(By.Id("userEmail"));
            email.SendKeys("zikaspiric@yahoo.com");


        }
        [TearDown]
        public void Close()
        {

            drive.Quit();
        
        }
    }
}
