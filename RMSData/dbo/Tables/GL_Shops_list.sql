CREATE TABLE [dbo].[GL_shops_list] (
  [Id] int PRIMARY KEY IDENTITY(1, 1),
  [Name] varchar(50) NOT NULL,
  [Address] varchar(50) NULL,
  [City] varchar(20) NULL,
  [Postal_code] varchar(7) NULL,
  [Email] varchar(20) NULL,
  [Mobile1] varchar(20) NULL,
  [Mobile2] varchar(20) NULL,
  [Mobile3] varchar(20) NULL,
  [Operating] bit NOT NULL
)
