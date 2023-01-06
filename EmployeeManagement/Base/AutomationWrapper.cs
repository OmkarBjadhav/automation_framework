using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace EmployeeManagement.Base
{
    public class AutomationWrapper
    {


        protected IWebDriver driver;

        [SetUp]
        // This Method will run before the [Test]Method
        public void beforeMethod()
        {

            string browserValue = "firefox";
            if (browserValue.ToLower().Equals("edge"))
            {
                driver = new EdgeDriver();
            }
            else if(browserValue.ToLower().Equals("firfox"))
            {
                driver = new FirefoxDriver();

            }
            else
            {
                driver = new ChromeDriver();

            }

           
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

        }

        //This Method will run after the [Test] Method no matter it is fail or pass.
        [TearDown]
        public void afterMethod()
        {
            driver.Quit();
        }

    }
}
