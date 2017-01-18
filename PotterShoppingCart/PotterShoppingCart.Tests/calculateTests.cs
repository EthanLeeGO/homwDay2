using Microsoft.VisualStudio.TestTools.UnitTesting;
using booklib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAutomation;

namespace booklib.Tests
{
    [TestClass()]
    public class calculateTests : FluentTest
    {
        [TestMethod()]
        public void CalBooksTest_買不同兩本()
        {
            List<Order> books = new List<Order>()
             {
                new Order() { book = new Potter1(), quantity = 1 },
                new Order() { book = new Potter2(), quantity = 1 }
             };

            var target = calculate.CalBooks(books);
            var expected = 190;
            Assert.AreEqual(expected, target);
        }

        public calculateTests()
        {
            // 要用多瀏覽器跑web測試時，只需要加入Bootstrap()中即可
            SeleniumWebDriver.Bootstrap(
                SeleniumWebDriver.Browser.Chrome
            //SeleniumWebDriver.Browser.Firefox
            //SeleniumWebDriver.Browser.InternetExplorer
            );

            //var path = @"C:\SkillTreeScreenShot";
            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}

            //Config.ScreenshotOnFailedAction(true)
            //    .ScreenshotPath(path);
        }

        private string baseUrl = "http://localhost:1292/";
        [TestMethod()]
        public void CalBooksTest_一二三集各買了一本()
        {
            I.Open(baseUrl + "/WebForm1.aspx")
                  .Enter("1").In("#txtPotter1")
                   .Enter("1").In("#txtPotter2")
                    .Enter("1").In("#txtPotter3")
                     .Click("input[id=\"Button1\"]")
                     .Assert.Text("270");
        }

        [TestMethod()]
        public void CalBooksTest_一二三四集各買了一本()
        {
            I.Open(baseUrl + "/WebForm1.aspx")
                  .Enter("1").In("#txtPotter1")
                   .Enter("1").In("#txtPotter2")
                    .Enter("1").In("#txtPotter3")
                    .Enter("1").In("#txtPotter4")
                     .Click("input[id=\"Button1\"]")
                     .Assert.Text("320");
        }

        [TestMethod()]
        public void CalBooksTest_一二三四五集各買了一本()
        {
            I.Open(baseUrl + "/WebForm1.aspx")
                  .Enter("1").In("#txtPotter1")
                   .Enter("1").In("#txtPotter2")
                    .Enter("1").In("#txtPotter3")
                    .Enter("1").In("#txtPotter4")
                    .Enter("1").In("#txtPotter5")
                     .Click("input[id=\"Button1\"]")
                     .Assert.Text("375");
        }

        [TestMethod()]
        public void CalBooksTest_一二集各買了一本_第三集買了兩本()
        {
            I.Open(baseUrl + "/WebForm1.aspx")
                  .Enter("1").In("#txtPotter1")
                   .Enter("1").In("#txtPotter2")
                    .Enter("2").In("#txtPotter3")
                    .Enter("0").In("#txtPotter4")
                    .Enter("0").In("#txtPotter5")
                     .Click("input[id=\"Button1\"]")
                     .Assert.Text("370");
        }

        [TestMethod()]
        public void CalBooksTest_第一集買了一本_第二三集各買了兩本()
        {
            I.Open(baseUrl + "/WebForm1.aspx")
                  .Enter("1").In("#txtPotter1")
                   .Enter("2").In("#txtPotter2")
                    .Enter("2").In("#txtPotter3")
                    .Enter("0").In("#txtPotter4")
                    .Enter("0").In("#txtPotter5")
                     .Click("input[id=\"Button1\"]")
                     .Assert.Text("460");
        }
    }
}