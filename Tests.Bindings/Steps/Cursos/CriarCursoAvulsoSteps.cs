using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TabMedia.Bindings.Pages;
using TabMedia.Bindings.Utils;
using TechTalk.SpecFlow;

namespace TabMedia.Bindings.Steps.Cursos
{
    [Binding]
    public class CriarCursoAvulsoSteps
    {
        private readonly IWebDriver _driver;
        private HomePage homepage;
        private LoginPage loginPage;
        private CursosPage cursosPage;
        private CadastroCursosPage cadastroCursosPage;
        private WebDriverWait driverWait;

        public CriarCursoAvulsoSteps()
        {
            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
           // driverWait = new WebDriverWait(_driver, TimeSpan.FromMilliseconds(5000));
        }

      
        [Given(@"Que estou logado no sistema TabMedia")]
        public void GivenQueEstouLogadoNoSistemaTabMedia()
        {
            loginPage = new LoginPage(_driver);
            loginPage.LogarComoAdministrator();
        }

        [When(@"Acesso o Menu para cadastro de cursos")]
        public void WhenAcessoOMenuParaCadastroDeCursos()
        {
            homepage = new HomePage(_driver);
            homepage.SelecionarMenuTrilhas();
        }

        [When(@"Clico na opção Criar Curso Avulso")]
        public void WhenClicoNaOpcaoCriarCursoAvulso()
        {
            cursosPage = new CursosPage(_driver);
            cursosPage.CriarCursoAvulso();
        }

        [When(@"Preencho os campos")]
        public void WhenPreenchoOsCampos(Table table)
        {
            cadastroCursosPage = new CadastroCursosPage(_driver);

            var dictionary = TableExtensions.ToDictionary(table);
            cadastroCursosPage.PreencherCamposPasso1(dictionary["Titulo"], dictionary["Descricao"]);
        }

        [When(@"Clico na opção próximo passo")]
        public void ThenClicoNaOpcaoProximoPasso()
        {
            cadastroCursosPage.IrParaProximoPasso();
        }

        [When(@"Faço Upload do Arquivo")]
        public void WhenFacoUploadDoArquivo()
        {
            cadastroCursosPage.FazerUploadConteudo();
        }

    }
}
