using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TabMedia.Bindings.Pages
{
    public class CadastroCursosPage
    {

        private readonly IWebDriver _driver;
        private readonly string _url = "http://localhost:10373/samueltab/cursos/cadastro/descricao";

        public CadastroCursosPage(IWebDriver driver)
        {
            _driver = driver;
        }



        #region Passo 1
        private IWebElement Titulo => _driver.FindElement(By.Id("Nome"));
        private IWebElement Descricao => _driver.FindElement(By.Id("Descricao"));
        private IWebElement ProximoButton => _driver.FindElement(By.CssSelector("[href *= 'javascript:saveAndContinue()']"));
        #endregion

        #region Passo 2

        IList<IWebElement> webElementsButtons => _driver.FindElements(By.ClassName("course-content__upload__dropzone dz-clickable"));

        private IWebElement UploadArquivoButton => _driver.FindElement(By.XPath("//*[contains(@class, '" + "upload__dropzone dz-clickable" + "')]"));

        //private IWebElement UploadArquivo => _driver.FindElement(By.ClassName("course-content__upload__dropzone dz-clickable"));
        IList <IWebElement> webElementsButtons2 => _driver.FindElements(By.ClassName("course-contents__actions__import"));

        private IWebElement ConteudoDeTreinamentoButton => _driver.FindElement(By.XPath("//button[contains(@class,'course-contents__actions__import__button tab-button tab-button--raised')]"));

        #endregion



        public void PreencherCamposPasso1(string titulo,string descricao)
        {
            Titulo.SendKeys(titulo);
            Descricao.SendKeys(descricao);
        }

        public void IrParaProximoPasso()
        {
            ProximoButton.Click();
        }

        public void FazerUploadConteudo()
        {
            //UploadArquivoButton.SendKeys("C:\\Users\\Samuel\\Desktop\\TabMedia\\Regua.png");
            UploadArquivoButton.Click();
            Thread.Sleep(2000);
        }

    }

   

}
