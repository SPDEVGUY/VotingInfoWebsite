-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[MetaData_SelectBy_MetaDataId]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[MetaData_SelectBy_MetaDataId]
GO--
CREATE PROCEDURE [Data].[MetaData_SelectBy_MetaDataId] 
			@MetaDataId int
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[MetaDataId],
			[ContentInspectionId],
			[MetaDataName],
			[IsRequired],
			[AppliesAtAllLevels],
			[AppliesToCandidates],
			[AppliesToOrganizations]
	FROM	[Data].[MetaData]
	WHERE	[MetaDataId] = @MetaDataId

END