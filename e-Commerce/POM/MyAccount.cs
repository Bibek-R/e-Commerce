using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;


namespace Practise.POM
{
    internal class MyAccount

    {
        IWebDriver driver; //Field for service methods to use

        //Constructor to get driver from test for use in the class
        public MyAccount(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locators
        IWebElement shop => driver.FindElement(By.LinkText("Shop"));
        IWebElement usernameTextBox => driver.FindElement(By.Id("username"));
        IWebElement passwordTextBox => driver.FindElement(By.Id("password"));
        IWebElement checkoutMenuItem => driver.FindElement(By.LinkText("Checkout"));
        IWebElement loginButton => driver.FindElement(By.Name("login"));
        IWebElement ordersLink => driver.FindElement(By.LinkText("Orders"));
        IWebElement logoutButton => driver.FindElement(By.LinkText("Logout"));

        //Service Methods
        public void ShopPage()   //method to click on the shop page
        {
            shop.Click();
        }

        public void UsernameTextBox(string username) //method to set the username
        {
            usernameTextBox.SendKeys(username);
        }

        public void PasswordTextBox(string password) //method to set the password 
        {
            passwordTextBox.SendKeys(password);
        }

        public void CheckOutMenuItem()  //method to select on checkout 
        {
            checkoutMenuItem.Click();
        }
        public void LoginButton()  //method to click on login button
        {
            loginButton.Click();
        }
        public void OrdersMenuItem()  //method to select the orders option 
        {
            ordersLink.Click();
        }
        public void LogoutButton()  //method to click on the logout button
        {
            logoutButton.Click();
        }

    }
}
