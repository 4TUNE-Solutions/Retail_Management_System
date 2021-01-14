CREATE TABLE [dbo].[INV_state]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[ArticleId] INT NOT NULL, 
	[InventoryId] INT NOT NULL,
	[CountNumber] FLOAT NOT NULL,
	[PurchasePrice] FLOAT NOT NULL,
	[SellingMargin] FLOAT NOT NULL
)
