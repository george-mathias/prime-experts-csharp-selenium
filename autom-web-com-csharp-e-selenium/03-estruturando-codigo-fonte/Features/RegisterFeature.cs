using _03_estruturando_codigo_fonte.Steps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;

namespace _03_estruturando_codigo_fonte.Features
{
    [TestClass]
    public class RegisterFeature
    {
        [TestMethod]
        public void SkipSignInComSucesso()
        {
            ChromeDriver driver = new ChromeDriver();

            try
            {
                #region setup
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                driver.Url = "http://demo.automationtesting.in/Index.html";
                #endregion

                #region scenario
                IndexSteps.ClickSkipSignIn(driver);

                Assert.IsTrue(driver.Url.Contains("Register"), "Skip Sign In realizado com Sucesso");
                #endregion

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

        [TestMethod]
        public void CadastroComSucesso()
        {
            ChromeDriver driver = new ChromeDriver();

            try
            {
                #region setup
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(60);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                driver.Url = "http://demo.automationtesting.in/Index.html";
                #endregion

                #region scenario
                IndexSteps.ClickSkipSignIn(driver);
                #endregion

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

        [TestMethod]
        public void CadastroComFalha()
        {
            
        }
    }
}
