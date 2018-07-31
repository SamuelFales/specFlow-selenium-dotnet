using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabMedia.Bindings.Pages.Sections.HomePageSections
{
    public partial class MenuPrincipalSection
    {
        private readonly IWebDriver _driver;

        public MenuPrincipalSection(IWebDriver browser)
        {
            this._driver = browser;
        }

        public IWebElement TreinamentosLink => _driver.FindElement(By.LinkText("Treinamentos"));
        public IWebElement TrilhasLink => _driver.FindElement(By.LinkText("Trilhas"));
    }
}
