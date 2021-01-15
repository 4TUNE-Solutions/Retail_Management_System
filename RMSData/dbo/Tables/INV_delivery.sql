CREATE TABLE [dbo].[INV_delivery]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[ShopId] INT NOT NULL,
	[InventoryId] INT NOT NULL,
	[DeliveryDate] DATE NOT NULL,
	[IsRealized] BIT NOT NULL
)