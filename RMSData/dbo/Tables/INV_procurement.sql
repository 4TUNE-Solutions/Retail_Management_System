CREATE TABLE [dbo].[INV_procurement]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[SuplierId] INT NOT NULL,
	[InventoryId] INT NOT NULL,
	[CreationDate] DATE NOT NULL,
	[IsRealized] BIT NOT NULL
)