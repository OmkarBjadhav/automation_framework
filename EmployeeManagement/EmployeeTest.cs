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
    public class EmployeeTest : AutomationWrapper
    {
        [Test, TestCaseSource(typeof(DataSource), nameof(DataSource.ValidEmployeeData1))]
        public void AddValidEmployeeTest(string username, string password, string firstName, string middleName, string lastName, string expectedResult)
        {

            // Given the username and password credentials 
            driver.FindElement(By.Name("username")).SendKeys(username);
            driver.FindElement(By.Name("password")).SendKeys(password);

            //Login in to the system
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            //Steps to add the new Employee
            driver.FindElement(By.XPath("//span[text()='PIM']")).Click();
            driver.FindElement(By.LinkText("Add Employee")).Click();
            driver.FindElement(By.Name("firstName")).SendKeys(firstName);
            driver.FindElement(By.Name("middleName")).SendKeys(middleName);
            driver.FindElement(By.Name("lastName")).SendKeys(lastName);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            string dynamicPath = "//h6[contains(normalize-space(),'@@@@')]";
            dynamicPath = dynamicPath.Replace("@@@@", firstName);


            string nameValidation = driver.FindElement(By.XPath(dynamicPath)).Text;
            Assert.That(nameValidation.Contains(expectedResult));

            // Print the Employee name(Not required)
            Console.WriteLine(nameValidation);

        }

    }
}