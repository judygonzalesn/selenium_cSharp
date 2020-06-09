using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpProject.BaseClass;
using System;
using System.Threading;

namespace SeleniumCSharpProject
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test,Category("Smoke Testing")]
        public void TestMethod1()
        {
                IWebElement emailField = driver.FindElement(By.Id("email"));
                emailField.SendKeys("juday.com.ph");


        }
        [Test,Category("Regression")]
        public void TestMethod2()
        {
            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("juday.com.ph");
        }
        [Test, Category("Smoke Testing")]
        public void TestMethod3()
        {
            IWebElement emailField = driver.FindElement(By.Id("email"));
            emailField.SendKeys("@com.ph");
            Thread.Sleep(5000);

        }
    }
}
