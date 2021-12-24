using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumPractice
{
    public class Tests
    {
        public IWebDriver driver;
        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:8888/index.php");
           
        }

        [Test]
        public void Test1()

        {
           
            driver.FindElement(By.Name("user_name")).SendKeys("admin");
            driver.FindElement(By.Name("user_password")).SendKeys("admin");
            driver.FindElement(By.Id("submitButton")).Click();

        }
        [OneTimeTearDown]
        public void close()
        {
            driver.Close();
        }
    }
}