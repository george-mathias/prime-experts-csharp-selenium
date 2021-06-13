using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace _02_abrindo_web_browser
{
    [TestClass]
    public class GoogleTest
    {
        [TestMethod]
        public void TestePesquisar()
        {
            ChromeDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                driver.Url = "https://google.com.br";

                driver.FindElementByXPath("//input[@name='q']").SendKeys("carros" + Keys.Enter);

                Assert.IsTrue(driver.FindElementByXPath("//a[text()='Shopping']").Enabled);
            }
            catch (Exception e)
            {
                driver.Quit();
                Assert.Fail($"{e.Message}\n" +
                            $"{e.InnerException}\n" +
                            $"{e.StackTrace}");
            }

            driver.Quit();
        }
    }
}
