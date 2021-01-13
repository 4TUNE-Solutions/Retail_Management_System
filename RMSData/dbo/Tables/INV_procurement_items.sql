CREATE TABLE [dbo].[INV_procurement_items]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Procurement_id] INT NOT NULL,
	[Article_id] INT NOT NULL,
	[Amount_number] FLOAT NOT NULL
)
