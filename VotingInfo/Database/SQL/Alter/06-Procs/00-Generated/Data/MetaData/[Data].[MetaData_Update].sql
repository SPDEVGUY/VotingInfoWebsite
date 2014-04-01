-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[MetaData_Update]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[MetaData_Update]
GO--
CREATE PROCEDURE [Data].[MetaData_Update] 
			@MetaDataId int,
			@ContentInspectionId int,
			@MetaDataName varchar(150),
			@IsRequired bit,
			@AppliesAtAllLevels bit,
			@AppliesToCandidates bit,
			@AppliesToOrganizations bit
AS --Generated--
BEGIN

	UPDATE	[Data].[MetaData] SET 
			[ContentInspectionId] = @ContentInspectionId,
			[MetaDataName] = @MetaDataName,
			[IsRequired] = @IsRequired,
			[AppliesAtAllLevels] = @AppliesAtAllLevels,
			[AppliesToCandidates] = @AppliesToCandidates,
			[AppliesToOrganizations] = @AppliesToOrganizations
	WHERE	[MetaDataId] = @MetaDataId

END