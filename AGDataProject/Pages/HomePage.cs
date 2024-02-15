using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AGDataProject.Pages
{
    public class HomePage : DriverHelper
    {
        IWebElement DropDownCompany => driver.FindElement(By.XPath("(//a[@href='#'][normalize-space()='Company'])[1]")); 
    
        public void ClickDropDownCompany() => DropDownCompany.Click();
    
    }

}
