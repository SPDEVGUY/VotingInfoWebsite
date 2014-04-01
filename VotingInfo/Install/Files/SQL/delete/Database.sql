USE [master]

-- This script drops the specified database

DECLARE @DatabaseName as nvarchar(30); SET @DatabaseName = 'VotingInfo';





-------------------------------------------------------------------
-- LOGIC CODE BELOW, EDIT DATABASE NAME ABOVE
-------------------------------------------------------------------
-- Drop database backup history
if exists(select * from sys.databases where name = @DatabaseName)
	EXEC msdb.dbo.sp_delete_database_backuphistory @database_name = @DatabaseName
-- Drops all existing connections
if exists(select * from sys.databases where name = @DatabaseName)
	EXEC('ALTER DATABASE [' + @DatabaseName + '] SET SINGLE_USER WITH ROLLBACK IMMEDIATE')
-- Drops Database
if exists(select * from sys.databases where name = @DatabaseName)
	EXEC('DROP DATABASE [' + @DatabaseName + ']')

GO--


-- This script drops the SQL login created by the scripts.
DECLARE @DatabaseName as nvarchar(30); SET @DatabaseName = 'VotingInfo';
DECLARE @AccountName as nvarchar(30);  SET @AccountName = 'BUILTIN\Administrators';
DECLARE @UseWindowsAuth as bit; SET @UseWindowsAuth = 1;





-------------------------------------------------------------------
-- LOGIC CODE BELOW, EDIT DATABASE NAME ABOVE
-------------------------------------------------------------------

IF @UseWindowsAuth = 0 AND EXISTS (SELECT * FROM sys.server_principals WHERE name = @AccountName)
	EXEC('DROP LOGIN [' + @AccountName + ']');
GO--
