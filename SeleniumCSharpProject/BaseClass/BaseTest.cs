using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumCSharpProject.BaseClass
{
   public class BaseTest
    {
       public IWebDriver driver;

        [SetUp]
        public void Open() {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            // driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Url = "https://www.phptravels.net/home";
            

        }
        [TearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}
