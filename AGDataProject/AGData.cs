using AGDataProject.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Xml.Serialization;

namespace AGDataProject
   
{
    public class AGData : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            driver = new ChromeDriver(); 
        }

        [Test]
        public void AGDataTest()
        {
            var homePage = new HomePage();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.agdata.com/");
            homePage.ClickDropDownCompany();

        }
    }
}