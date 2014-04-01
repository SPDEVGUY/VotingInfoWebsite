-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Organization_Update]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Organization_Update]
GO--
CREATE PROCEDURE [Data].[Organization_Update] 
			@OrganizationId int,
			@ContentInspectionId int,
			@OrganizationName varchar(250)
AS --Generated--
BEGIN

	UPDATE	[Data].[Organization] SET 
			[ContentInspectionId] = @ContentInspectionId,
			[OrganizationName] = @OrganizationName
	WHERE	[OrganizationId] = @OrganizationId

END