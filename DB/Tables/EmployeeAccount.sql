CREATE TABLE [dbo].[EmployeeAccount]
(
	[EmployeeID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Account] VARCHAR(20) NOT NULL, 
    [Password] VARCHAR(20) NOT NULL, 
    [Prompt] VARCHAR(100) NULL,
	[LastLogin] DATETIME NOT NULL
)
