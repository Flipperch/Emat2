CREATE PROCEDURE [dbo].[spEnsino_Insert]
	@EnsinoNome varchar(50)
AS
BEGIN
	INSERT INTO ENSINO (NOME_ENSINO)
	VALUES (@EnsinoNome)
END
