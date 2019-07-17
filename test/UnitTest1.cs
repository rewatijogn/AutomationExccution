using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using EAGetMail;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
 public void TestMethod1()
        {
            IWebDriver crmDriver = new ChromeDriver();
            crmDriver.Navigate().GoToUrl("https://www.google.co.in");
            IWebElement SearchTxt = crmDriver.FindElement(By.XPath("//*[@id=\"tsf\"]/div[2]/div/div[1]/div/div[1]/input"));
            SearchTxt.SendKeys("GitHub");
            SearchTxt.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            crmDriver.Close();


        }
        
                [TestMethod]

        public void TestMethod3()
        {
            IWebDriver crmDriver = new ChromeDriver();
            crmDriver.Navigate().GoToUrl("https://www.google.co.in");
            IWebElement SearchTxt = crmDriver.FindElement(By.XPath("//*[@id=\"tsf\"]/div[2]/div/div[1]/div/div[1]/input"));
            SearchTxt.SendKeys("GitHub2");
            SearchTxt.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            crmDriver.Close();


        }
        [TestMethod]
        public void TestMethod2()
        {
            IWebDriver crmDriver = new ChromeDriver();
            crmDriver.Navigate().GoToUrl("https://www.google.co.in");
            IWebElement SearchTxt = crmDriver.FindElement(By.XPath("//*[@id=\"tsf\"]/div[2]/div/div[1]/div/div[1]/input"));
            SearchTxt.SendKeys("GitHub1");
            SearchTxt.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            crmDriver.Close();


        }

    }
}

