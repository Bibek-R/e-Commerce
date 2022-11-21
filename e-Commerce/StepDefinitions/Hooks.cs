using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using Practise.POM;
using TechTalk.SpecFlow;

namespace Practise.StepDefinitions
{
    [Binding]
    public class Hooks
    {
        private IWebDriver s_driver;
        private readonly ScenarioContext _scenarioContext;
        public Hooks(ScenarioContext sc)
        {
            _scenarioContext = sc;
        }


        [BeforeScenario]
        public void Setup()
        {

            string browser = Environment.GetEnvironmentVariable("BROWSER");

            //Multibrowser testing
            switch (browser)
            {
                case "firefox":
                    s_driver = new FirefoxDriver();


                    break;

                case "chrome":
                    s_driver = new ChromeDriver();


                    break;

                case "edge":
                    s_driver = new EdgeDriver();


                    break;

                default:

                    s_driver = new ChromeDriver();

                    break;
            }
            s_driver.Url = Environment.GetEnvironmentVariable("url");  //Opens the e-commerce website
            s_driver.Manage().Window.Maximize();    //Maximise the window
            s_driver.FindElement(By.CssSelector(".woocommerce-store-notice__dismiss-link")).Click();  //Dismss the blue notification bar
            _scenarioContext["myDriver"] = s_driver;

        }

        [AfterScenario]
        public void TearDown()
        {
            s_driver.Quit(); //Close all tabs, windows for session, closes webdriver session.
        }
    }
}