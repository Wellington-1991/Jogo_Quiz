# Pacotes instalados
### Microsoft.EntityFrameworkCore.SqlSERVER 6.0.22
### Microsoft.EntityFrameworkCore.Tools     6.0.22
### System.Configuration.ConfiguraManager   6.0.22

# Projeto
### Windows Forms 6.0.1

# Criação de tabelas
### EntityFrameWork 

# Insert nas tabelas Perguntas e Respostas
### 
INSERT INTO Pergunta(PerguntaQuiz,DataCriacao,DataExclusao,DataAlteracao,Excluido)
VALUES ('Qual a cor do cavalo branco de Napoleão?',GETDATE(), null,null,0)


INSERT INTO Resposta(RespostaQuiz,PerguntaID,Verdadeiro,DataCriacao,DataExclusao,DataAlteracao,Excluido)
VALUES('Roxo',1,1,GETDATE(),null,null,0),
('Branco',1,0,GETDATE(),null,null,0),
('Amarelo',1,0,GETDATE(),null,null,0)

INSERT INTO Pergunta(PerguntaQuiz,DataCriacao,DataExclusao,DataAlteracao,Excluido)
VALUES ('Quantos meses tem um ano?',GETDATE(), null,null,0)


INSERT INTO Resposta(RespostaQuiz,PerguntaID,Verdadeiro,DataCriacao,DataExclusao,DataAlteracao,Excluido)
VALUES('12',1,1,GETDATE(),null,null,0),
('11',1,0,GETDATE(),null,null,0),
('13',1,0,GETDATE(),null,null,0)
