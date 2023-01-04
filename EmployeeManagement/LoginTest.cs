using EmployeeManagement.Base;
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
            driver.FindElement(By.Name("username")).SendKeys("Admin");
            driver.FindElement(By.Name("password")).SendKeys("admin123");
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string pageUrl = driver.Url;

            // Landing page Url Confirmation 
            Assert.That(pageUrl, Is.EqualTo("https://opensource-demo.orangehrmlive.com/web/index.php/dashboard/index"));
        }

        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.InvalidLoginData))]

        public void InvalidLoginTest(string username, string password, string expectedMsg)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            string errorMsg = driver.FindElement(By.XPath("//p[text()='Invalid credentials']")).Text;
            Assert.That(errorMsg.Contains(expectedMsg));

            // Print The Error MSG
            // Console.WriteLine(errorMsg);

        }
    }
}
