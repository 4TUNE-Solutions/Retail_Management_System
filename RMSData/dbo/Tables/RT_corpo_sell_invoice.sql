CREATE TABLE [dbo].[RT_corpo_sell_invoice]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CorpoId] INT NOT NULL, 
    [WorkerId] INT NULL, 
    [ShopId] INT NOT NULL, 
    [DateIssued] DATE NOT NULL, 
    [PaymentDedline] DATE NULL, 
    [InvoiceNumber] VARCHAR(50) NOT NULL, 
    [SumCash] FLOAT NULL, 
    [SumCard] FLOAT NULL, 
    [FinalSum] FLOAT NOT NULL, 
    [TAXAmount] FLOAT NOT NULL, 
    [DiscountAmount] FLOAT NULL, 
    [IsInvoicePaid] BIT NOT NULL
)
