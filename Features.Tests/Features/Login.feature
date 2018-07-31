@Login
Feature: Login
	Sendo um usuário do sistema 
    Posso acessar minha conta
    Para poder acessar as funcionalidades do sistema

@login
Scenario: Login por usuário administrador
	Given Que eu tenho o usuário 'admin@teste.com.br' e senha 'Test@1234'
	When Faço login
	Then Vejo o dashboard com o link "meu cadastro" e o link "sair"

Scenario: Login por usuário inválido
	Given Que eu tenho o usuário 'erro@teste.com.br' e senha 'Test@1234'
	When Faço login
	Then Vejo mensagem 'Ops! O usuário ou a senha estão errados.' para usuário ou senha incorreto
