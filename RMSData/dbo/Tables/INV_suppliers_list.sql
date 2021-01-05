CREATE TABLE [dbo].[INV_suppliers_list]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NULL, 
    [City] VARCHAR(20) NULL, 
    [Postal_code] VARCHAR(7) NULL, 
    [Email] VARCHAR(20) NULL, 
    [Telephone] VARCHAR(20) NULL, 
    [Mobile] VARCHAR(20) NULL, 
    [Fax] VARCHAR(20) NULL, 
    [Website] VARCHAR(50) NULL, 
    [Contact_person] VARCHAR(50) NULL, 
    [Bank_account_number1] VARCHAR(50) NULL, 
    [Bank_account_number2] VARCHAR(50) NULL, 
    [TIN] VARCHAR(20) NOT NULL, 
    [UCID] VARCHAR(20) NOT NULL, 
    [Taxpayer] BIT NOT NULL
)
