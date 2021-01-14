CREATE TABLE [dbo].[GL_article_group]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Group_name] VARCHAR(50) NOT NULL, 
    [Group_color] VARCHAR(50) NULL, 
    [Discount_amount] INT NULL
)
