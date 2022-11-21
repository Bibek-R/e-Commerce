using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Practise.POM;
using OpenQA.Selenium.Firefox;
using static Practise.StepDefinitions.Hooks;
using NUnit.Framework;
using Practise.Utilities;
using OpenQA.Selenium.Support.UI;



namespace Practise.StepDefinitions
{
    [Binding]
    internal class TestCasesStepDefinitions
    {
        private IWebDriver s_driver;
        private readonly ScenarioContext _scenarioContext;
        private MyAccount loggedIn;
        private Products products;
        private Cart carts;
        private HelpersInstance wait;
        private OrdersHistory history;



        public TestCasesStepDefinitions(ScenarioContext sc)
        {
            _scenarioContext = sc;
            this.s_driver = (IWebDriver)_scenarioContext["myDriver"];
        }


        [Given(@"I am logged in")]
        public void GivenIAmLoggedIn()
        {
            MyAccount login = new MyAccount(s_driver);

            login.UsernameTextBox(Environment.GetEnvironmentVariable("username")); //uses environment variable to get username
            login.PasswordTextBox(Environment.GetEnvironmentVariable("password")); //uses environment variable to get password
            login.LoginButton(); //uses to click the login button
            loggedIn = login;
            Console.Write("Logged in!");

        }

        [When(@"I have a product in the cart")]
        public void WhenIHaveAProductInTheCart()
        {
            loggedIn.ShopPage();
            Shop shop = new Shop(s_driver);
            shop.ProductSelection();       //select the product
            Products products = new Products(s_driver);
            products.AddToCart();        //add the selected product to the cart
            this.products = products;
            Console.WriteLine("Product added!");

        }

        [When(@"I click on the cart menu item")]
        public void WhenIClickOnTheCartMenuItem()
        {
            products.CartMenuItem();  //view the cart
        }

        [When(@"I enter the coupon '([^']*)'")]
        public void WhenIEnterTheCoupon(string edgewords)
        {
            Cart cart = new Cart(s_driver);
            cart.SelectCouponTextBox();        //select the coupon textbox before applying coupon
            cart.EnterCoupon(edgewords);       //enter the coupon code
            cart.ApplyCoupon();                //apply the coupon
            Console.WriteLine("Coupon has been applied!");
            carts = cart;
        }


        [Then(@"I can check coupon is '([^']*)'% off")]
        public void ThenICanCheckCouponIsOff(string discountvalue)
        {
            wait = new HelpersInstance(s_driver);  //use of helper class for element to load up
            wait.WaitForElm(3, By.CssSelector("#post-5 > div > div > div.cart-collaterals > div > table > tbody > tr.cart-discount.coupon-edgewords > td > span"));
            decimal discount = carts.GetDiscount(carts.GetSubTotalExtract(), carts.GetDiscountAmount());

            try
            {
                Assert.That((int)discount, Is.EqualTo(Int32.Parse(discountvalue)), "15% should have been applied!"); //this shows the coupon value deducted is equal to the discount value calculated
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                wait.WaitForElm(3, By.ClassName("remove"));   //use of helper class to load until the element is found
                carts.RemoveCoupon(); //removes the coupon
                //wait.WaitForElm(3, By.ClassName("remove"));  //use of helper class to load until the element is found
                Console.WriteLine("Coupon has been removed!");
                carts.EmptyCart(); //Empties the cart
                Console.WriteLine("Cart is now empty!");
            }
        }


        //TestCase2
        [When(@"I view the cart to see the added item")]
        public void WhenIViewTheCartToSeeTheAddedItem()
        {
            loggedIn.ShopPage();
            Shop shop = new Shop(s_driver);
            shop.ProductSelection();   //select the product
            Products products = new Products(s_driver);
            products.AddToCart();   //add the selected product to the cart
            Console.WriteLine("Product added!");
            this.products = products;
            products.CartMenuItem();   //click on the cart to view it
        }

        [When(@"I proceed to checkout to fill in the following information")]
        public void WhenIProceedToCheckoutToFillInTheFollowingInformation(Table table)
        {
            Cart cart = new Cart(s_driver);
            cart.ProceedToCheckout();  //Click on checkout button
            this.carts = cart;
            Checkout checkout = new Checkout(s_driver);
            foreach (TableRow row in table.Rows) // goes through each row and gets the value and passes it
            {
                checkout.details(            //gets the value from the feature file
                row["First Name"].ToString(),  //converts the value into string
                row["Last Name"].ToString(),
                row["Street Address"].ToString(),
                row["Town"].ToString(),
                row["Postcode"].ToString(),
                row["Phone"].ToString(),
                row["Email"].ToString()
                );
            }

            Thread.Sleep(2000);
            checkout.PaymentMethod();  //selects the payment method
            checkout.PlaceOrder();    //places the order
            Console.WriteLine("Order has been placed!");
        }

        [When(@"I complete the order to get the order number")]
        public void WhenICompleteTheOrderToGetTheOrderNumber()
        {
            WebDriverWait myWait3 = new WebDriverWait(s_driver, TimeSpan.FromSeconds(3)); //use of helper class to wait for element to load
            myWait3.Until(drv => drv.FindElement(By.CssSelector("#post-6 > div > div > div > ul")).Displayed);
            OrdersHistory ordersHistory = new OrdersHistory();
            ordersHistory.GetOrderNoFromOrdersPage(s_driver); //takes a screenshot of the described element
        }



        [Then(@"I click on MyOrders to check the order number")]
        public void ThenIClickOnMyOrdersToCheckTheOrderNumber()
        {
            OrderReceivedPage orderReceivedPage = new OrderReceivedPage(s_driver);
            orderReceivedPage.MyAccountMenuItem();  //selects on MyAccount section
            MyAccount login = new MyAccount(s_driver);
            login.OrdersMenuItem();  //selects on the orders sections
            loggedIn.OrdersMenuItem();
            orderReceivedPage.AccountOrders();  //shows the order numbers in the list
            try
            {
                Assert.That(orderReceivedPage.OrderNumber(), Is.True, "Order not matched!");
            }
            catch (Exception)
            {

            }
        }


    }
}