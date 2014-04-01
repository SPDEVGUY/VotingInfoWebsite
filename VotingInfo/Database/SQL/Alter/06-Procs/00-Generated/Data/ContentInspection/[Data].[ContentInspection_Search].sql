-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ContentInspection_Search]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ContentInspection_Search]
GO--
CREATE PROCEDURE [Data].[ContentInspection_Search] 
			@SourceUrl varchar(250) = NULL
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[ContentInspectionId],
			[IsArchived],
			[IsBeingProposed],
			[ProposedByUserId],
			[ConfirmedByUserId],
			[FalseInfoCount],
			[TrueInfoCount],
			[AdminInpsected],
			[DateLastChecked],
			[SourceUrl]
	FROM	[Data].[ContentInspection]
	WHERE	(@SourceUrl IS NULL OR [SourceUrl] LIKE '%' + @SourceUrl + '%')

END