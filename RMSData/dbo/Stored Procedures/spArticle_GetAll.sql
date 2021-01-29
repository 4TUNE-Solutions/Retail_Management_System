CREATE PROCEDURE [dbo].[spArticle_GetAll]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT *
	FROM dbo.GL_article_list
	ORDER BY ArticleName;
END
