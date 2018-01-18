using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject
{
    public class FirstTest
    {
        IWebDriver driver = new FirefoxDriver();

        [Test]
        public void myFirstTest()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            Assert.AreEqual("Google", driver.Title);

            driver.Close();

            driver.Quit();

        }
    }
}
