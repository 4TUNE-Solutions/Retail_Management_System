CREATE PROCEDURE [dbo].[spArticle_GetById]
	@id int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM GL_article_list
	WHERE Id = @id;

END
