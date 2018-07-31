Feature: CriarCursoAvulso
	Para usar os serviços de cursos e trilhas
	Como usuário administrador
	Desejo criar um curso avulso 

@criarCursoAvulso
Scenario: Criar curso avulso como administrador
	Given Que estou logado no sistema TabMedia
	When Acesso o Menu para cadastro de cursos 
	And Clico na opção Criar Curso Avulso
	And Preencho os campos 
	| field     | value                                        |
	| Titulo    | Curso avulso teste automatizado              |
	| Descricao | Descricao de curso teste avulso automatizado |
	And Clico na opção próximo passo
	And Faço Upload do Arquivo
	
