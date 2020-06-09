using NUnit.Framework;
using NUnit.Framework.Internal.Execution;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpProject.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumCSharpProject

{
    [TestFixture]
    public class tableTest
    {
        IWebDriver driver = null;
        

         [SetUp]
                 public void start()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
           
        }

     
        [Test]
        public void test1()
        {
            try
            {

                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.facebook.com/";
                IWebElement email = driver.FindElement(By.Id("email"));
                Assert.IsTrue(email.Displayed);
                string txt = "Hello";
                email.SendKeys(txt);
                Assert.AreEqual(txt, email.GetAttribute("value"));
                IWebElement emailLabel = driver.FindElement(By.CssSelector("[for*='email']"));
                Assert.AreEqual("Email or Phone", emailLabel.Text);
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\JUDYANNGONZALES\\Desktop\\Projects\\SeleniumCSharp\\SeleniumCSharpProject\\Report\\Screenshots\\s1.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }

        }
        [Test]
        public void test2()
        {

            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.worldometers.info/coronavirus/#countries";
                Actions actions = new Actions(driver);
                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 30));
                By phElement = By.CssSelector("[id='main_table_countries_today']>tbody>tr:nth-of-type(49)>td:nth-of-type(2)");
                By tableElement = By.CssSelector("[id='main_table_countries_today']");
                IWebElement philippinesTxt = driver.FindElement(phElement);
                IWebElement table = driver.FindElement(tableElement);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(tableElement));
                actions.MoveToElement(table);
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(phElement));
                Assert.AreEqual(true, philippinesTxt.Displayed);
                Thread.Sleep(5000);
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\JUDYANNGONZALES\\Desktop\\Projects\\SeleniumCSharp\\SeleniumCSharpProject\\Report\\Screenshots\\s1.jpeg", ScreenshotImageFormat.Jpeg);

                Console.WriteLine(e.StackTrace);
                throw;
            }

            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }


            Console.WriteLine("");
            driver.Quit();
        }
        [Test]
        public void pomAndPageFactory()
        {

            try
            {
                tablePage tablepg = new tablePage(driver);
                tablepg.goToPage();
                tablepg.verifyTextInside();
                                 }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\JUDYANNGONZALES\\Desktop\\Projects\\SeleniumCSharp\\SeleniumCSharpProject\\Report\\Screenshots\\s1.jpeg", ScreenshotImageFormat.Jpeg);
                 Console.WriteLine(e.StackTrace);
                throw;
            }

            finally
            {
                if (driver != null)
                {
                    driver.Quit();
                }
            }


            Console.WriteLine("");
            driver.Quit();
        }

    }
}

