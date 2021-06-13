using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01_introducao_ao_csharp_com_selenium
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
                Assert.Fail();
            }
            catch (Exception)
            {
                driver.Quit();
            }
        }
    }
}
