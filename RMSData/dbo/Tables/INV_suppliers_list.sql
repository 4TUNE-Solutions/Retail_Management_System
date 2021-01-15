CREATE TABLE [dbo].[INV_suppliers_list]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NULL, 
    [City] VARCHAR(20) NULL, 
    [PostalCode] VARCHAR(7) NULL, 
    [Email] VARCHAR(20) NULL, 
    [Telephone] VARCHAR(20) NULL, 
    [Mobile] VARCHAR(20) NULL, 
    [Fax] VARCHAR(20) NULL, 
    [Website] VARCHAR(50) NULL, 
    [ContactPerson] VARCHAR(50) NULL, 
    [BankAccountNumber1] VARCHAR(50) NULL, 
    [BankAccountNumber2] VARCHAR(50) NULL, 
    [TIN] VARCHAR(20) NOT NULL, 
    [UCID] VARCHAR(20) NOT NULL, 
    [IsTaxpayer] BIT NOT NULL
)
