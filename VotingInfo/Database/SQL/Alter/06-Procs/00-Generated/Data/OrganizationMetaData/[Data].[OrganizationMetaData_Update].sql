-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[OrganizationMetaData_Update]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[OrganizationMetaData_Update]
GO--
CREATE PROCEDURE [Data].[OrganizationMetaData_Update] 
			@OrganizationMetaDataId int,
			@ContentInspectionId int,
			@OrganizationId int,
			@MetaDataId int,
			@MetaDataValue varchar(max)
AS --Generated--
BEGIN

	UPDATE	[Data].[OrganizationMetaData] SET 
			[ContentInspectionId] = @ContentInspectionId,
			[OrganizationId] = @OrganizationId,
			[MetaDataId] = @MetaDataId,
			[MetaDataValue] = @MetaDataValue
	WHERE	[OrganizationMetaDataId] = @OrganizationMetaDataId

END