CREATE TABLE [dbo].[GL_retail_costs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ShopId] INT NOT NULL, 
    [TypeOfPay] INT NOT NULL, 
    [IssuanceDay] DATE NOT NULL, 
    [DueMonth] INT NOT NULL, 
    [DueYear] INT NOT NULL, 
    [Cost] FLOAT NOT NULL, 
    [PaymentCode] INT NULL, 
    [ReferenceNumber] VARCHAR(50) NULL, 
    [PayerName] VARCHAR(50) NOT NULL
)
