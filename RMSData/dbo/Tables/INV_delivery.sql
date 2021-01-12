CREATE TABLE [dbo].[INV_delivery]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Shop_id] int,
	[Inventory_id] int,
	[Delivery_date] date,
	[Realized] bit
)
