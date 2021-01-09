CREATE TABLE [dbo].[RT_state]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Shop_id] INT NOT NULL, 
    [Article_id] INT NOT NULL, 
    [Count_number] FLOAT NOT NULL, 
    [Selling_price] FLOAT NOT NULL, 
    [Discount] INT NULL, 
    [Expiration_date] DATE NULL
)
