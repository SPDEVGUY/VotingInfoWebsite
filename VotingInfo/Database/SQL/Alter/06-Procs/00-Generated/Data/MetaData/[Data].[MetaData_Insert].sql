-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[MetaData_Insert]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[MetaData_Insert]
GO--
CREATE PROCEDURE [Data].[MetaData_Insert]
			@ContentInspectionId int,
			@MetaDataName varchar(150),
			@IsRequired bit,
			@AppliesAtAllLevels bit,
			@AppliesToCandidates bit,
			@AppliesToOrganizations bit
AS --Generated--
BEGIN

	INSERT INTO [Data].[MetaData] (

			[ContentInspectionId],
			[MetaDataName],
			[IsRequired],
			[AppliesAtAllLevels],
			[AppliesToCandidates],
			[AppliesToOrganizations]
	) VALUES (

			@ContentInspectionId,
			@MetaDataName,
			@IsRequired,
			@AppliesAtAllLevels,
			@AppliesToCandidates,
			@AppliesToOrganizations
	)

	SELECT CAST(SCOPE_IDENTITY() AS int) AS [MetaDataId]
END