CREATE TABLE [dbo].[INV_state]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Article_id] int not null, 
	[Inventory_id] int,
	[Count_number] float,
	[Purchase_price] float,
	[Selling_margin] float
)
