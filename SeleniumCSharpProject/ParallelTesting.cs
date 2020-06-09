using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpProject.Utilities;
using System;
using System.Threading;

namespace SeleniumCSharpProject
{
    [TestFixture]
    public class ParallelTesting

    {
        IWebDriver driver;
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod1()
        {
            var Driver = new browserUtility().Init(driver);
            IWebElement emailField = Driver.FindElement(By.Id("email"));
            emailField.SendKeys("juday_271@yahoo.com.ph");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod2()
        {
            var Driver = new browserUtility().Init(driver);
            IWebElement emailField = Driver.FindElement(By.Id("email"));
            emailField.SendKeys("juday_271@yahoo.com.ph");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod3()
        {
            var Driver = new browserUtility().Init(driver);
            IWebElement emailField = Driver.FindElement(By.Id("email"));
            emailField.SendKeys("juday_271@yahoo.com.ph");
            Driver.Close();
        }
        [Test, Category("UAT Testing"), Category("Module1")]
        public void TestMethod4()
        {
            var Driver = new browserUtility().Init(driver);
            IWebElement emailField = Driver.FindElement(By.Id("email"));
            emailField.SendKeys("juday_271@yahoo.com.ph");
            Driver.Close();
        }

    }
}
