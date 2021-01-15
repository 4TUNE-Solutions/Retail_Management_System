CREATE TABLE [dbo].[RT_state]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ShopId] INT NOT NULL, 
    [ArticleId] INT NOT NULL, 
    [CountNumber] FLOAT NOT NULL, 
    [SellingPrice] FLOAT NOT NULL, 
    [Discount] INT NULL, 
    [ExpirationDate] DATE NULL
)
