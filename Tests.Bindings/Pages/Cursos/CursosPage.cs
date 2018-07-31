using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabMedia.Bindings.Pages
{
    public class CursosPage
    {
        private readonly IWebDriver _driver;
       
        public CursosPage(IWebDriver driver)
        {
            _driver = driver;
        }


        //IList<IWebElement> webElementsButtons => _driver.FindElements(By.ClassName("page-action-buttons"));
        private IWebElement CriarCursoAvulsoLink => _driver.FindElement(By.CssSelector("[href*='/samueltab/cursos/cadastro/descricao']"));

        public IWebElement FiltroText => _driver.FindElement(By.Id("txtFilter"));

        public void CriarCursoAvulso()
        {
            CriarCursoAvulsoLink.Click();
   
        }
    }
}
