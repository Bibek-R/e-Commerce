using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Practise.POM
{
    internal class OrderReceivedPage
    {
        IWebDriver driver;  //Field for service methods to use


        //Constructor to get driver from test for use in the class
        public OrderReceivedPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Locators
        IWebElement myAccountMenuItem => driver.FindElement(By.LinkText("My account"));
        IWebElement orderNumber => driver.FindElement(By.CssSelector("#post-6 > div > div > div > ul > li.woocommerce-order-overview__order.order"));
        //"));
        IWebElement accountOrders => driver.FindElement(By.CssSelector("tr:nth-of-type(1) > .woocommerce-orders-table__cell.woocommerce-orders-table__cell-order-number"));


        //Service Methods
        public void MyAccountMenuItem()   //method to click on MyAccount
        {
            myAccountMenuItem.Click();
        }

        public bool OrderNumber()      //shows the latest order number
        {
            return orderNumber.Displayed;
        }

        public String AccountOrders()   //shows the order numbers in the orders list
        {
            string orders = accountOrders.Text;
            Console.WriteLine("MyAccount Order Number is " + orders);
            return accountOrders.Text;
        }


    }
}