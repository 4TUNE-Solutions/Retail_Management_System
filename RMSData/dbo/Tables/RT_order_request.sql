CREATE TABLE [dbo].[RT_order_request]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Inventory_id] INT NOT NULL, 
    [Shop_id] INT NOT NULL, 
    [Creation_date] DATE NULL, 
    [Realized] BIT NOT NULL
)
