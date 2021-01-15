CREATE TABLE [dbo].[GL_retail_costs_types]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ServiceName] VARCHAR(20) NOT NULL, 
    [ServiceBankAccountNumber] VARCHAR(20) NULL
)
