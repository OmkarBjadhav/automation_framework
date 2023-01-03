using EmployeeManagement.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement 
{

    public class LoginUITest : AutomationWrapper
    { 
        [Test]
        public void ValidateTitleTest()
        {
           
            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);

            Assert.That(actualTitle, Is.EqualTo("OrangeHRM"));

        }

        [Test]
        public void ValidatePlaceholderTest()
        {
           
            string actualUsernamePlaceHolder=driver.FindElement(By.Name("username")).GetAttribute("placeholder");
            Assert.That(actualUsernamePlaceHolder, Is.EqualTo("Username"));


            string actualPasswordPlaceHolder = driver.FindElement(By.Name("password")).GetAttribute("placeholder");
            Assert.That(actualPasswordPlaceHolder, Is.EqualTo("Password"));
        }
    }
}