using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using Practise.Utilities;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.CommonModels;

namespace Practise.POM
{
    internal class OrdersHistory
    {
        //method to take screenshot of the described element of the webpage
        public void GetOrderNoFromOrdersPage(IWebDriver _driver)
        {
            IWebElement form = _driver.FindElement(By.CssSelector("#post-6 > div > div > div > ul"));
            HelpersInstance.TakeScreenshotElement(form, "orderhistory");
            TestContext.AddTestAttachment(@"C:\Screenshots\orderhistory.png");
        }

    }
}
