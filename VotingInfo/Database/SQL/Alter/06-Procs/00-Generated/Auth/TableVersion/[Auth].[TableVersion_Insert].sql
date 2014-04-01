-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Auth].[TableVersion_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Auth].[TableVersion_Insert]
GO--
CREATE PROCEDURE [Auth].[TableVersion_Insert]
			@TableName varchar(150),
			@Version int
AS --Generated--
BEGIN

	INSERT INTO [Auth].[TableVersion] (

			[TableName],
			[Version]
	) VALUES (

			@TableName,
			@Version
	)

	SELECT CAST(SCOPE_IDENTITY() AS int) AS [TableId]
END