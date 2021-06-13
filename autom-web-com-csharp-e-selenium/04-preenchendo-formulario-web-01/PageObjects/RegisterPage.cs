
using OpenQA.Selenium;

namespace _04_preenchendo_formulario_web_01.PageObjects
{
    public class RegisterPage
    {
        public static By FirstName = By.CssSelector("input[placeholder='First Name']");
        public static By LastName = By.CssSelector("input[placeholder='Last Name']");
        
        public static By BtnSubmit = By.CssSelector("button[id = 'submitbtn']");
    }
}
