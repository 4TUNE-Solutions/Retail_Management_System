CREATE TABLE [dbo].[RT_order_request]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [InventoryId] INT NOT NULL, 
    [ShopId] INT NOT NULL, 
    [CreationDate] DATE NULL, 
    [IsRealized] BIT NOT NULL
)
