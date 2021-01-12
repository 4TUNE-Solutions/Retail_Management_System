CREATE TABLE [dbo].[INV_procurement]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Suplier_id] int,
	[Inventory_id] int,
	[Creation_date] date,
	[Realized] bit
)
