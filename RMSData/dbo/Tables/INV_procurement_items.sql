CREATE TABLE [dbo].[INV_procurement_items]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Procurement_id] int,
	[Article_id] int,
	[Amount_number] float
)
