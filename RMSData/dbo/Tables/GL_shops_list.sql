CREATE TABLE [dbo].[GL_shops_list] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Name] varchar(50),
  [Address] varchar(50),
  [City] varchar(20),
  [Postal_code] varchar(7),
  [Email] varchar(20),
  [Mobile1] varchar(20),
  [Mobile2] varchar(20),
  [Mobile3] varchar(20),
  [Operating] bit
)
