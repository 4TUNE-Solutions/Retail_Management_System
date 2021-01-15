CREATE TABLE [dbo].[GL_article_grouping_connection]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [GroupId] INT NULL, 
    [SubGroupId] INT NULL, 
    [ArticleId] INT NOT NULL
)
