CREATE TABLE [dbo].[INV_procurement]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Suplier_id] INT NOT NULL,
	[Inventory_id] INT NOT NULL,
	[Creation_date] DATE NOT NULL,
	[Realized] BIT NOT NULL
)