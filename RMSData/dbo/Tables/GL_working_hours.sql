CREATE TABLE [dbo].[GL_working_hours]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Shop_id] INT NOT NULL, 
    [Day] VARCHAR(50) NOT NULL, 
    [Opening_hours] TIME NULL, 
    [Closing_hours] TIME NULL, 
    [Working] BIT NOT NULL
)
