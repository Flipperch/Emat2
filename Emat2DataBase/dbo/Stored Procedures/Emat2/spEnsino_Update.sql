CREATE PROCEDURE [dbo].[spEnsino_Update]
	@Id int,
	@EnsinoNome varchar(50)
AS
BEGIN
	UPDATE ENSINO
	SET NOME_ENSINO = @EnsinoNome
	WHERE CODIGO = @Id
END
