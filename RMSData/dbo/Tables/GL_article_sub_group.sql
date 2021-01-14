CREATE TABLE [dbo].[GL_article_sub_group]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Group_id] INT NOT NULL, 
    [Sub_group_id] INT NULL, 
    [Sub_group_name] VARCHAR(50) NOT NULL, 
    [Sub_group_color] VARCHAR(50) NULL, 
    [Discount_amount] INT NULL
)
