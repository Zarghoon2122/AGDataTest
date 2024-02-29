using OpenQA.Selenium;

namespace AGDataProject.Pages
{
    public class HomePage : DriverHelper
    {
        //Elements
        IWebElement ddCompany => driver.FindElement(By.XPath("(//a[@href='#'][normalize-space()='Company'])[1]"));
        IWebElement btnOverview => driver.FindElement(By.XPath("(//a[normalize-space()='Overview'])[1]"));
        IWebElement btnLetsGetStarted => driver.FindElement(By.XPath("(//a[normalize-space()=\"Let's Get Started\"])[1]"));
    
        //Methods
        public void ClickCompany() => ddCompany.Click();
        public void ClickOverview() => btnOverview.Click();
        public void ClickLetsGetStarted() => btnLetsGetStarted.Click();
    
    }

}
