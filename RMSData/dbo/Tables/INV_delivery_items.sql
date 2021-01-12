CREATE TABLE [dbo].[INV_delivery_items]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Shop_id] int,
	[Article_id] int,
	[Amount_number] float
)
