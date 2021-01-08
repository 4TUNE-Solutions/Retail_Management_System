CREATE TABLE [dbo].[RT_corpo_sell_invoice]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Corpo_id] INT NOT NULL, 
    [Worker_id] INT NULL, 
    [Shop_id] INT NOT NULL, 
    [Date_issued] DATE NOT NULL, 
    [Payment_dedline] DATE NULL, 
    [Invoice_number] VARCHAR(50) NOT NULL, 
    [Sum_cash] FLOAT NULL, 
    [Sum_card] FLOAT NULL, 
    [Final_sum] FLOAT NOT NULL, 
    [TAX_amount] FLOAT NOT NULL, 
    [Discount_amount] FLOAT NULL, 
    [Invoice_paid] BIT NOT NULL
)
