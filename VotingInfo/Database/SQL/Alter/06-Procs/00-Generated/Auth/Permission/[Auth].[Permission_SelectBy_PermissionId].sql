-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Auth].[Permission_SelectBy_PermissionId]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Auth].[Permission_SelectBy_PermissionId]
GO--
CREATE PROCEDURE [Auth].[Permission_SelectBy_PermissionId] 
			@PermissionId int
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[PermissionId],
			[PermissionName],
			[Title],
			[IsRead]
	FROM	[Auth].[Permission]
	WHERE	[PermissionId] = @PermissionId

END