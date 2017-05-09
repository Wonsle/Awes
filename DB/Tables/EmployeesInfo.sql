CREATE TABLE [dbo].[EmployeesInfo]
(
	[SID] INT IDENTITY NOT NULL PRIMARY KEY,    
	[EmployeeID] UNIQUEIDENTIFIER NOT NULL, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL,
	[NickName] VARCHAR(50) NULL, 
	[PostLevel] SMALLINT NOT NULL, 
	[TWID] VARCHAR(10) NOT NULL,
	[Sex] TINYINT NOT NULL, 	           
	[Email] VARCHAR(50) NULL, 		
	[Birthday] DATETIME2 NULL,  
    [RegistTime] DATETIME NOT NULL, 
    [LeaveTime] DATETIME NULL,     
)
