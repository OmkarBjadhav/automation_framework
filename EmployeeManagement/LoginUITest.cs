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
        //new

        [Test]
        public void ValidatePlaceholderTest()
        {
           


            string actualUsernamePlaceHolder=driver.FindElement(By.Name("username")).GetAttribute("placeholder");
            string actualPasswordPlaceHolder = driver.FindElement(By.Name("password")).GetAttribute("placeholder");
            Assert.That(actualPasswordPlaceHolder, Is.EqualTo("Password"));
            Assert.That(actualUsernamePlaceHolder, Is.EqualTo("Username"));
        }
    }
}