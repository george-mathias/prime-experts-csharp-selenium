using OpenQA.Selenium.Remote;

namespace _04_preenchendo_formulario_web_01
{
    public static class IndexSteps
    {
        public static void ClickSkipSignIn(this RemoteWebDriver driver)
        {
            driver.FindElement(IndexPage.SkipSignIn).Click();
        }
    }
}
