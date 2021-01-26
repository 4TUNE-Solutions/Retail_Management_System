CREATE PROCEDURE [dbo].[spArticle _Delete]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE GL_article_list
	WHERE Id = @Id;

END
