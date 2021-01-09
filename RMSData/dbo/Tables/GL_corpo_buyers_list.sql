CREATE TABLE [dbo].[GL_corpo_buyers_list]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(20) NOT NULL, 
    [Adress] VARCHAR(40) NULL, 
    [City] VARCHAR(20) NULL, 
    [Postal_code] VARCHAR(15) NULL, 
    [Email] VARCHAR(50) NULL, 
    [Telephone] VARCHAR(15) NULL, 
    [Mobile] VARCHAR(15) NULL, 
    [Fax] VARCHAR(20) NULL, 
    [Website] VARCHAR(40) NULL, 
    [Contact_person] VARCHAR(50) NULL, 
    [Bank_account_number] VARCHAR(50) NULL, 
    [TIN] VARCHAR(50) NOT NULL, 
    [UCID] VARCHAR(50) NOT NULL, 
    [Taxpayer] BIT NOT NULL
)
