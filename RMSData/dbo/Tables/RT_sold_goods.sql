CREATE TABLE [dbo].[RT_sold_goods]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Fiscall_bill_id] INT NOT NULL, 
    [Article_id] INT NOT NULL, 
    [Amount] FLOAT NOT NULL, 
    [Article_cost] FLOAT NOT NULL, 
    [Article_TAX] FLOAT NOT NULL, 
    [Article_discount] FLOAT NULL
)
