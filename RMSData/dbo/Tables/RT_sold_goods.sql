CREATE TABLE [dbo].[RT_sold_goods]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FiscallBillId] INT NOT NULL, 
    [ArticleId] INT NOT NULL, 
    [Amount] FLOAT NOT NULL, 
    [ArticleCost] FLOAT NOT NULL, 
    [ArticleTAX] FLOAT NOT NULL, 
    [ArticleDiscount] FLOAT NULL
)
