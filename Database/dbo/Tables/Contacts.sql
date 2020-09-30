CREATE TABLE [dbo].[Contacts]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [first_name] VARCHAR(MAX) NULL, 
    [last_name] VARCHAR(MAX) NULL, 
    [date_of_birth] DATETIME2 NULL, 
    [email] VARCHAR(MAX) NULL, 
    [campagne_id] INT NOT NULL
)
