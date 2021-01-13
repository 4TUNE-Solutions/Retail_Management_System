CREATE TABLE [dbo].[INV_delivery_items]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Shop_id] INT NOT NULL,
	[Article_id] INT NOT NULL,
	[Amount_number] FLOAT NOT NULL
)