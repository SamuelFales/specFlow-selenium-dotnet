using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TabMedia.Bindings.Pages.Sections.HomePageSections;

namespace TabMedia.Bindings.Pages
{
    public partial class HomePage
    {

        private readonly IWebDriver _driver;
        private MenuPrincipalSection MenuPrincipalSection { get; }
        private WebDriverWait driverWait;

        private CursosPage cursosPage;

        public HomePage(IWebDriver driver)
        {
            this._driver = driver;
            MenuPrincipalSection = new MenuPrincipalSection(driver);
            //driverWait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(5000));
        }

        public IWebElement MeuCadastroLink => _driver.FindElement(By.LinkText("meu cadastro"));
        public IWebElement SairLink => _driver.FindElement(By.LinkText("sair"));

        public void SelecionarMenuTrilhas()
        {
            MenuPrincipalSection.TreinamentosLink.Click();
            MenuPrincipalSection.TrilhasLink.Click();
        }

        private void WaitUntilLoaded()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            wait.Until((x) =>
            {
                return ((IJavaScriptExecutor)_driver).ExecuteScript("return document.readyState").Equals("complete");
            });
        }

    }
}
