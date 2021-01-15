CREATE TABLE [dbo].[GL_working_hours]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ShopId] INT NOT NULL, 
    [Day] VARCHAR(50) NOT NULL, 
    [OpeningHours] TIME NULL, 
    [ClosingHours] TIME NULL, 
    [IsWorking] BIT NOT NULL
)
