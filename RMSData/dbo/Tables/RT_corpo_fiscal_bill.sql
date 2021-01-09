CREATE TABLE [dbo].[RT_corpo_fiscal_bill]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Corpo_id] INT NOT NULL, 
    [Shop_id] INT NOT NULL, 
    [Fiscall_bill_id] INT NOT NULL, 
    [Date_time_issued] DATETIME NOT NULL
)
