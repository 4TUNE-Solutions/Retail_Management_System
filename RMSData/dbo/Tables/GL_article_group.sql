CREATE TABLE [dbo].[GL_article_group]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [GroupName] VARCHAR(50) NOT NULL, 
    [GroupColor] VARCHAR(50) NULL, 
    [DiscountAmount] INT NULL
)
