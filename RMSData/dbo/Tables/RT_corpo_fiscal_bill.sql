CREATE TABLE [dbo].[RT_corpo_fiscal_bill]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CorpoId] INT NOT NULL, 
    [ShopId] INT NOT NULL, 
    [FiscallBillId] INT NOT NULL, 
    [DateTimeIssued] DATETIME2 NOT NULL
)
