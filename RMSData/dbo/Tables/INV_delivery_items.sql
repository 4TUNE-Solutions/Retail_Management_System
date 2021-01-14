CREATE TABLE [dbo].[INV_delivery_items]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[ShopId] INT NOT NULL,
	[ArticleId] INT NOT NULL,
	[AmountNumber] FLOAT NOT NULL
)