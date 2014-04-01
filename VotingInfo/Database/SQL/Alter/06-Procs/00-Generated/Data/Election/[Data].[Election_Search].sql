-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Election_Search]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Election_Search]
GO--
CREATE PROCEDURE [Data].[Election_Search] 
			@ElectionRegion varchar(150) = NULL
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[ElectionId],
			[ContentInspectionId],
			[ElectionLevelId],
			[ElectionRegion],
			[VotingDate]
	FROM	[Data].[Election]
	WHERE	(@ElectionRegion IS NULL OR [ElectionRegion] LIKE '%' + @ElectionRegion + '%')

END