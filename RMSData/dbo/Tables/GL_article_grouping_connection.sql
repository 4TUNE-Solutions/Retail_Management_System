CREATE TABLE [dbo].[GL_article_grouping_connection]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Group_id] INT NULL, 
    [Sub_group_id] INT NULL, 
    [Article_id] INT NOT NULL
)
