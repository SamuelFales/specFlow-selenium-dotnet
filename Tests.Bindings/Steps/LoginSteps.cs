using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TabMedia.Bindings.Pages;
using TechTalk.SpecFlow;

namespace TabMedia.Bindings.Steps
{
    [Binding]
    public class LoginSteps
    {
        private readonly IWebDriver _driver;
        LoginPage login;
        HomePage homepage;

        public LoginSteps()
        {
            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
        }

        [Given(@"Que eu tenho o usuário '(.*)' e senha '(.*)'")]
        public void GivenQueEuTenhoOUsuarioESenha(string email, string senha)
        {
            login = new LoginPage(_driver);
            login.NavegarParaPagina();
            login.PreencherCamposLogin(email, senha);
        }

        [When(@"Faço login")]
        public void WhenFacoLogin()
        {
            login.EfetuarLogin();
        }

        [Then(@"Vejo o dashboard com o link ""(.*)"" e o link ""(.*)""")]
        public void ThenVejoODashboardComOLinkEOLink(string meucadastro, string sair)
        {
            homepage = new HomePage(_driver);

            var meucadastroRef = homepage.MeuCadastroLink.Text;
            var sairRef = homepage.SairLink.Text;

            Assert.IsTrue(meucadastroRef.Contains(meucadastro));
            Assert.IsTrue(sairRef.Contains(sair));
        }

        [Then(@"Vejo mensagem '(.*)' para usuário ou senha incorreto")]
        public void ThenVejoMensagemParaUsuarioOuSenhaIncorreto(string mensagemErro)
        {
            var mensagemErroRef = login.ErroMessage.Text;
            Assert.IsTrue(mensagemErroRef.Contains(mensagemErro));
        }


    }
}
