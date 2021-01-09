CREATE TABLE [dbo].[GL_inventory_list]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(20) NOT NULL, 
    [Adress] VARCHAR(40) NULL, 
    [City] VARCHAR(20) NULL, 
    [Postal_code] VARCHAR(15) NULL, 
    [Email] VARCHAR(50) NULL, 
    [Mobile] VARCHAR(15) NULL, 
    [Operating] BIT NOT NULL
)
