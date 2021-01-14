CREATE TABLE [dbo].[GL_access_level_accounts]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [WorkerName] VARCHAR(50) NULL, 
    [VisibleName] VARCHAR(50) NOT NULL, 
    [Username] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL, 
    [IsAdmin] BIT NOT NULL, 
    [IsManager] BIT NOT NULL
)
