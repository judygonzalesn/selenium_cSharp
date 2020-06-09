using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpProject.BaseClass;
using System;
using System.Threading;

namespace SeleniumCSharpProject
{
    [TestFixture]
    public class OrderSkipAttribute
    {
        [Test,Order(1),Category("OrderSkipAttribute")]
      
        public void TestMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("juday.com.ph");
            driver.Close();
        }
        [Test, Order(0),Category("OrderSkipAttribute")]
        public void TestMethod2()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("@com.ph");
            driver.Close();

        }

     
    }
}
