CREATE TABLE [dbo].[RT_fiscal_bills]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [WorkerId] INT NULL, 
    [ShopId] INT NOT NULL, 
    [BuyerId] INT NULL, 
    [ReferenceNumber] INT NOT NULL, 
    [SumCash] FLOAT NULL, 
    [SumCard] FLOAT NULL, 
    [FinalSum] FLOAT NOT NULL, 
    [MoneyGiven] FLOAT NOT NULL, 
    [CashBack] FLOAT NOT NULL, 
    [DateTimeIssues] DATETIME NOT NULL, 
    [TAXAmount] FLOAT NOT NULL, 
    [DiscountAmount] FLOAT NULL
)
