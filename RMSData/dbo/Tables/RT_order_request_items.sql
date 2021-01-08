CREATE TABLE [dbo].[RT_order_request_items]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Request_id] INT NOT NULL, 
    [Article_id] INT NOT NULL, 
    [Amount_number] FLOAT NOT NULL
)
