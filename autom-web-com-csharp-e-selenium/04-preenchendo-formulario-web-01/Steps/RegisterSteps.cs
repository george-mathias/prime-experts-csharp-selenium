using _04_preenchendo_formulario_web_01.PageObjects;
using OpenQA.Selenium.Remote;

namespace _04_preenchendo_formulario_web_01.Steps
{
    public static class RegisterSteps
    {
        public static void FillFirstName(this RemoteWebDriver driver, string text)
        {
            driver.FindElement(RegisterPage.FirstName).SendKeys(text);
        }

        public static void FillLastName(this RemoteWebDriver driver, string text)
        {
            driver.FindElement(RegisterPage.LastName).SendKeys(text);
        }

        public static void ClickSubmitButton(this RemoteWebDriver driver)
        {
            driver.FindElement(RegisterPage.BtnSubmit).Click();
        }
    }
}
