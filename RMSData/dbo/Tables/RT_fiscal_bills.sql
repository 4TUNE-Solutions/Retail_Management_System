CREATE TABLE [dbo].[RT_fiscal_bills]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Worker_id] INT NULL, 
    [Shop_id] INT NOT NULL, 
    [Buyer_id] INT NULL, 
    [Reference_number] INT NOT NULL, 
    [Sum_cash] FLOAT NULL, 
    [Sum_card] FLOAT NULL, 
    [Final_sum] FLOAT NOT NULL, 
    [Money_given] FLOAT NOT NULL, 
    [Cash_back] FLOAT NOT NULL, 
    [Date_time_issues] DATETIME2 NOT NULL, 
    [TAX_amount] FLOAT NOT NULL, 
    [Discount_amount] NCHAR(10) NULL
)
