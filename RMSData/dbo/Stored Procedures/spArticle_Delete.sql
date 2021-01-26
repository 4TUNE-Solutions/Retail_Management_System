CREATE PROCEDURE [dbo].[spArticle_Delete]
	@Id int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE GL_article_list
	WHERE Id = @Id;

END
