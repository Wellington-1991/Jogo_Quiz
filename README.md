# Projeto.
- Windows Forms 6.0.1
  
# Pacotes instalados.
- Microsoft.EntityFrameworkCore.SqlSERVER 6.0.22
- Microsoft.EntityFrameworkCore.Tools     6.0.22
- System.Configuration.ConfiguraManager   6.0.22
  
# Criando o banco de dados.
- Estou usando o EntityFrameWork para criar as tebelas no banco.
- No Package Manager Console digite "Update-database", esse comando vai criar as tabelas no SqlServer.

#  Insirindo Perguntas e Respostas nas tabelas criadas.

- INSERT INTO Pergunta(PerguntaQuiz,DataCriacao,DataExclusao,DataAlteracao,Excluido)
-VALUES ('Qual a cor do cavalo branco de Napoleão?',GETDATE(), null,null,0)


- INSERT INTO Resposta(RespostaQuiz,PerguntaID,Verdadeiro,DataCriacao,DataExclusao,DataAlteracao,Excluido)
VALUES('Roxo',1,1,GETDATE(),null,null,0),
('Branco',1,0,GETDATE(),null,null,0),
('Amarelo',1,0,GETDATE(),null,null,0)

- INSERT INTO Pergunta(PerguntaQuiz,DataCriacao,DataExclusao,DataAlteracao,Excluido)
VALUES ('Quantos meses tem um ano?',GETDATE(), null,null,0)

- INSERT INTO Resposta(RespostaQuiz,PerguntaID,Verdadeiro,DataCriacao,DataExclusao,DataAlteracao,Excluido)
VALUES('12',1,1,GETDATE(),null,null,0),
('11',1,0,GETDATE(),null,null,0),
('13',1,0,GETDATE(),null,null,0)

# Informações para executar o Jogo.
- Buildar o projeto.
- O jogo começa com o botão Inicar.
- Para cada pergunta terá 3 opções de resposta, apenas uma é a correta.
  


