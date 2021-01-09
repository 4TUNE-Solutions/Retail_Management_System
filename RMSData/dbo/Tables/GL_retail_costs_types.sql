CREATE TABLE [dbo].[GL_retail_costs_types]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Service_name] VARCHAR(20) NOT NULL, 
    [Service_bank_account_number] VARCHAR(20) NULL
)
