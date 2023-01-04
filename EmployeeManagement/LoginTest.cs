using EmployeeManagement.Base;
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
        public static object[] InvalidLoginData()
        {
            string[] dataset1 = new string[3];
            dataset1[0] = "John";
            dataset1[1] = "john123";
            dataset1[2] = "Invalid credentials";


            string[] dataset2 = new string[3];
            dataset2[0] = "peter";
            dataset2[1] = "peter123";
            dataset2[2] = "Invalid credentials";


            string[] dataset3 = new string[3];
            dataset3[0] = "saul";
            dataset3[1] = "saul123";
            dataset3[2] = "Invalid credentials";

            object[] allDataSet = new object[3];
            allDataSet[0] = dataset1;
            allDataSet[1] = dataset2;
            allDataSet[2] = dataset3;
            return allDataSet;
        }






        [Test,TestCaseSource(nameof(InvalidLoginData))]
      //  [TestCase("John", "john123", "Invalid credential")]
       // [TestCase("peter", "peter123", "Invalid credential")]
        public void InvalidLoginTest(string username, string password, string expectedMsg)
        {
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            string errorMsg = driver.FindElement(By.XPath("//p[text()='Invalid credentials']")).Text;
            Assert.That(errorMsg.Contains(expectedMsg));

            // Print The Error MSG
            Console.WriteLine(errorMsg);

        }
    }
}
