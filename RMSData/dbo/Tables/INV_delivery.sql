CREATE TABLE [dbo].[INV_delivery]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Shop_id] INT NOT NULL,
	[Inventory_id] INT NOT NULL,
	[Delivery_date] DATE NOT NULL,
	[Realized] BIT NOT NULL
)