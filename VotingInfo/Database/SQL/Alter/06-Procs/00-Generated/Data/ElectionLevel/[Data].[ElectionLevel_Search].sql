-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ElectionLevel_Search]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ElectionLevel_Search]
GO--
CREATE PROCEDURE [Data].[ElectionLevel_Search] 
			@ElectionLevelTitle varchar(150) = NULL
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[ElectionLevelId],
			[ContentInspectionId],
			[ElectionLevelTitle]
	FROM	[Data].[ElectionLevel]
	WHERE	(@ElectionLevelTitle IS NULL OR [ElectionLevelTitle] LIKE '%' + @ElectionLevelTitle + '%')

END