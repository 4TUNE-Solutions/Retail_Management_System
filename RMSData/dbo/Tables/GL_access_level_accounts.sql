CREATE TABLE [dbo].[GL_access_level_accounts]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Worker_name] VARCHAR(50) NULL, 
    [Visible_name] VARCHAR(50) NOT NULL, 
    [Username] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL, 
    [Is_admin] BIT NOT NULL, 
    [Is_manager] BIT NOT NULL
)
