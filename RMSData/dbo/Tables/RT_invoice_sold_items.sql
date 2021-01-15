CREATE TABLE [dbo].[RT_invoice_sold_items]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [InvoiceId] INT NOT NULL, 
    [ArticleId] INT NOT NULL, 
    [Amount] FLOAT NOT NULL, 
    [ArticleCost] FLOAT NOT NULL, 
    [ArticleTAX] FLOAT NOT NULL, 
    [ArticleDiscount] FLOAT NULL
)
