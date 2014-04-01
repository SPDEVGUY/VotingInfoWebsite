-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[OrganizationMetaData_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[OrganizationMetaData_Insert]
GO--
CREATE PROCEDURE [Data].[OrganizationMetaData_Insert]
			@ContentInspectionId int,
			@OrganizationId int,
			@MetaDataId int,
			@MetaDataValue varchar(max)
AS --Generated--
BEGIN

	INSERT INTO [Data].[OrganizationMetaData] (

			[ContentInspectionId],
			[OrganizationId],
			[MetaDataId],
			[MetaDataValue]
	) VALUES (

			@ContentInspectionId,
			@OrganizationId,
			@MetaDataId,
			@MetaDataValue
	)

	SELECT CAST(SCOPE_IDENTITY() AS int) AS [OrganizationMetaDataId]
END