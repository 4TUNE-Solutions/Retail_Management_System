CREATE TABLE [dbo].[GL_shops_list]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NULL, 
    [City] VARCHAR(50) NULL, 
    [Postal_code] VARCHAR(50) NULL, 
    [email] VARCHAR(50) NULL, 
    [mobile] VARCHAR(50) NULL, 
    [mobile2] VARCHAR(50) NULL, 
    [mobile3] VARCHAR(50) NULL, 
    [operating] BIT NOT NULL
)
