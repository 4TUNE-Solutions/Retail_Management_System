CREATE TABLE [dbo].[INV_procurement_items]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[ProcurementId] INT NOT NULL,
	[ArticleId] INT NOT NULL,
	[AmountNumber] FLOAT NOT NULL
)
