CREATE TABLE [dbo].[RT_invoice_sold_items]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Invoice_id] INT NOT NULL, 
    [Article_id] INT NOT NULL, 
    [Amount] FLOAT NOT NULL, 
    [Article_cost] FLOAT NOT NULL, 
    [Article_TAX] FLOAT NOT NULL, 
    [Article_discount] FLOAT NULL
)
