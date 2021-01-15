CREATE TABLE [dbo].[GL_article_sub_group]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [GroupId] INT NOT NULL, 
    [SubGroupId] INT NULL, 
    [SubGroupName] VARCHAR(50) NOT NULL, 
    [SubGroupColor] VARCHAR(50) NULL, 
    [DiscountAmount] INT NULL
)
