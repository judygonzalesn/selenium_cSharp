using System;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;

namespace SeleniumCSharpProject.BaseClass
{
    class tablePage
    {

        String test_url = "https://www.worldometers.info/coronavirus/#countries";
        private IWebDriver driver;
        private WebDriverWait wait;
        


        public tablePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            PageFactory.InitElements(driver, this);
            
        }
        [FindsBy(How = How.CssSelector, Using = "[id='main_table_countries_today']>tbody>tr:nth-of-type(49)>td:nth-of-type(2)")]
        private IWebElement phElement;
        

        [FindsBy(How = How.CssSelector, Using = "[id='main_table_countries_today']")]
        private IWebElement tableElement;

        public void goToPage()
        {
            driver.Navigate().GoToUrl(test_url);
        }

        public void verifyTextInside()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(phElement);
            Assert.AreEqual("Philippines", phElement.Text);
        }
    }
}

