-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ElectionLevel_SelectBy_ElectionLevelId]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ElectionLevel_SelectBy_ElectionLevelId]
GO--
CREATE PROCEDURE [Data].[ElectionLevel_SelectBy_ElectionLevelId] 
			@ElectionLevelId int
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[ElectionLevelId],
			[ContentInspectionId],
			[ElectionLevelTitle]
	FROM	[Data].[ElectionLevel]
	WHERE	[ElectionLevelId] = @ElectionLevelId

END