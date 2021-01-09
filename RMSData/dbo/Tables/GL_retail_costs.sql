CREATE TABLE [dbo].[GL_retail_costs]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Shop_id] INT NOT NULL, 
    [Type_of_pay] INT NOT NULL, 
    [Issuance_] DATE NOT NULL, 
    [Due_month] INT NOT NULL, 
    [Due_year] INT NOT NULL, 
    [Cost] FLOAT NOT NULL, 
    [Payment_code] INT NULL, 
    [Reference_number] VARCHAR(50) NULL, 
    [Payer_name] VARCHAR(50) NOT NULL
)
