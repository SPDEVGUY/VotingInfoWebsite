-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Election_SelectBy_ContentInspectionId]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Election_SelectBy_ContentInspectionId]
GO--
CREATE PROCEDURE [Data].[Election_SelectBy_ContentInspectionId] 
			@ContentInspectionId int
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[ElectionId],
			[ContentInspectionId],
			[ElectionLevelId],
			[LocationId],
			[VotingDate]
	FROM	[Data].[Election]
	WHERE	[ContentInspectionId] = @ContentInspectionId

END