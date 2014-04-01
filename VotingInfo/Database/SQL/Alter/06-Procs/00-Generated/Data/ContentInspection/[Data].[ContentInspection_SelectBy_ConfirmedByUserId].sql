-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ContentInspection_SelectBy_ConfirmedByUserId]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ContentInspection_SelectBy_ConfirmedByUserId]
GO--
CREATE PROCEDURE [Data].[ContentInspection_SelectBy_ConfirmedByUserId] 
			@ConfirmedByUserId int
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
	WHERE	[ConfirmedByUserId] = @ConfirmedByUserId

END