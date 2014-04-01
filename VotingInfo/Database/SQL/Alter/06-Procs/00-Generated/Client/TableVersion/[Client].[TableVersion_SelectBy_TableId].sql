-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Client].[TableVersion_SelectBy_TableId]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Client].[TableVersion_SelectBy_TableId]
GO--
CREATE PROCEDURE [Client].[TableVersion_SelectBy_TableId] 
			@TableId int
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[TableId],
			[TableName],
			[Version]
	FROM	[Client].[TableVersion]
	WHERE	[TableId] = @TableId

END