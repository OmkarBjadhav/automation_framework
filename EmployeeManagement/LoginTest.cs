using EmployeeManagement.Base;
using EmployeeManagement.Pages;
using EmployeeManagement.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class LoginTest : AutomationWrapper
    {
        [Test]
        public void ValidLoginTest()
        {
            LoginPage loginpage = new LoginPage(driver);

            loginpage.EnterUsername("Admin");
            loginpage.EnterPassword("admin123");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string pageUrl = driver.Url;

            // Landing page Url Confirmation 
            Assert.That(pageUrl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));
        }

        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLogindata2))]

        public void InvalidLoginTest(string username, string password, string expectedMsg)
        {
            LoginPage loginpage = new LoginPage(driver);

            loginpage.EnterUsername(username);
            loginpage.EnterPassword(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            string errorMsg = driver.FindElement(By.XPath("//p[text()='Invalid credentials']")).Text;
            Assert.That(errorMsg.Contains(expectedMsg));

            // Print The Error MSG
            // Console.WriteLine(errorMsg);

        }
    }
}
