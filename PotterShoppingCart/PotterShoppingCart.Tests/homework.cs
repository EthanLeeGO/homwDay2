using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    [TestClass]
    public class Homework
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [TestInitialize]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "http://localhost:1292/";
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void TheHomeworkTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/WebForm1.aspx");
            driver.FindElement(By.Id("txtPotter1")).Clear();
            driver.FindElement(By.Id("txtPotter1")).SendKeys("1");
            driver.FindElement(By.Id("txtPotter2")).Clear();
            driver.FindElement(By.Id("txtPotter2")).SendKeys("1");
            driver.FindElement(By.Id("txtPotter3")).Clear();
            driver.FindElement(By.Id("txtPotter3")).SendKeys("1");
            driver.FindElement(By.Id("txtPotter4")).Clear();
            driver.FindElement(By.Id("txtPotter4")).SendKeys("1");
            driver.FindElement(By.Id("txtPotter5")).Clear();
            driver.FindElement(By.Id("txtPotter5")).SendKeys("1");
            driver.FindElement(By.Id("Button1")).Click();
            Assert.AreEqual("3750", driver.FindElement(By.Id("txtTotal")).Text);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
