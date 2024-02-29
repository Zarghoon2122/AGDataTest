using AGDataProject.Pages;
using MySqlX.XDevAPI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace AGDataProject
   
{
    public class AGData : DriverHelper
    {
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(); 
        }

        [Test]
        public void AGDataTest()
        {
            
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.agdata.com/");
            var homePage = new HomePage();
            homePage.ClickCompany();
            homePage.ClickOverview();

            var btnLetsGetStarted = driver.FindElement(By.XPath("(//a[normalize-space()=\"Let's Get Started\"])[1]"));
            driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", btnLetsGetStarted);

            homePage.ClickLetsGetStarted();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.UrlContains("/contact"));

            driver.Quit();
            
        }
    }
}