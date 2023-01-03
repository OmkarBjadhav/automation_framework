using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EmployeeManagement
{
    public class LoginUITest
    {
        IWebDriver driver;

        [SetUp]
        // This Method will run before the [Test]Method
        public void beforeMethod()
        {
            driver = new ChromeDriver();
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