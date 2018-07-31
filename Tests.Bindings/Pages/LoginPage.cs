using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace TabMedia.Bindings.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _driver;
        private WebDriverWait driverWait;
        private readonly string _url = @"http://localhost:10373/login?ReturnUrl=%2f";

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
           // driverWait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(5000));
        }

        
        private IWebElement Email => _driver.FindElement(By.Id("Email"));
        private IWebElement Senha => _driver.FindElement(By.Id("Senha")); 
        private IWebElement EntrarButton => _driver.FindElement(By.CssSelector("input[type=submit]")); 
        private IWebElement LembrarSenhaLink => _driver.FindElement(By.LinkText("forgot the password?")); 
        private IWebElement LembrarUsuarioLink => _driver.FindElement(By.LinkText("forgot the user?"));
        public IWebElement ErroMessage => _driver.FindElement(By.ClassName("erro"));

        public void NavegarParaPagina()
        {
            _driver.Navigate().GoToUrl(_url);
        }

        public void PreencherCamposLogin(string email, string senha)
        {
            Email.SendKeys(email);
            Senha.SendKeys(senha);
        }

        public void EfetuarLogin()
        {
            EntrarButton.Click();
        }

        public void LogarComoAdministrator()
        {
            this.NavegarParaPagina();
            this.PreencherCamposLogin("admin@tabmedia.com.br", "Tab@1234");
            this.EfetuarLogin();
        }
    }
}
