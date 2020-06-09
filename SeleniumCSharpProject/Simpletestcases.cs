using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpProject.BaseClass;

namespace SeleniumCSharpProject
{
    [TestFixture]
    public class simpleTestcases
    {
        IWebDriver driver = null;

        [SetUp]
        public void start()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            tablePage tablepg = new tablePage(driver);
            tablepg.goToPage();
        }

        [Test]
        [Author("Judy", "judyanngonzalesn@gmail.com")]
        [Description("FaceBook Login Page")]
        [TestCaseSource("DataDriverTesting")]
        public void Test1(String urlName)
        {
            try
            {

                //driver.Url = "https://www.facebook.com/";
                driver.Url = urlName;
                IWebElement email = driver.FindElement(By.Id("email"));
               
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

        static IList DataDriverTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com/");
            list.Add("https://www.youtube.com/");
            list.Add("https://www.gmail.com/");
            return list;
        }
    }
}
