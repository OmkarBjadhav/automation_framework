using DocumentFormat.OpenXml.Bibliography;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Pages
{
    public  class LoginPage
    {
        IWebDriver driver;
        public LoginPage(IWebDriver driver)
        {

            this.driver = driver;
        }
        public  void EnterUsername(string username)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);

        }

        public  void EnterPassword(string password)
        {

            driver.FindElement(By.Name("password")).SendKeys(password);
        }

    }
}
