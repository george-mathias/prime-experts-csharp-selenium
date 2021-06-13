using _03_estruturando_codigo_fonte.PageObjects;
using OpenQA.Selenium.Remote;

namespace _03_estruturando_codigo_fonte.Steps
{
    public static class IndexSteps
    {
        public static void ClickSkipSignIn(this RemoteWebDriver driver)
        {
            driver.FindElement(IndexPage.SkipSignIn).Click();
        }
    }
}
