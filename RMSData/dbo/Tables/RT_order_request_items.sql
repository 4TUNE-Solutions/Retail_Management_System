CREATE TABLE [dbo].[RT_order_request_items]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RequestId] INT NOT NULL, 
    [ArticleId] INT NOT NULL, 
    [AmountNumber] FLOAT NOT NULL
)
