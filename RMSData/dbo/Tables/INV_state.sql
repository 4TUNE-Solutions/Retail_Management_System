CREATE TABLE [dbo].[INV_state]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Article_id] INT NOT NULL, 
	[Inventory_id] INT NOT NULL,
	[Count_number] FLOAT NOT NULL,
	[Purchase_price] FLOAT NOT NULL,
	[Selling_margin] FLOAT NOT NULL
)
