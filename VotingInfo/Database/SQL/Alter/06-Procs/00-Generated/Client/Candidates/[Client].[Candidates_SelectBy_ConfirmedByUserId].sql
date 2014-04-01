-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Client].[Candidates_SelectBy_ConfirmedByUserId]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Client].[Candidates_SelectBy_ConfirmedByUserId]
GO--
CREATE PROCEDURE [Client].[Candidates_SelectBy_ConfirmedByUserId] 
			@ConfirmedByUserId int
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[CandidateId],
			[ContentInspectionId],
			[CandidateName],
			[OrganizationId],
			[IsArchived],
			[IsBeingProposed],
			[ProposedByUserId],
			[ConfirmedByUserId],
			[FalseInfoCount],
			[TrueInfoCount],
			[AdminInpsected],
			[DateLastChecked],
			[SourceUrl]
	FROM	[Client].[Candidates]
	WHERE	[ConfirmedByUserId] = @ConfirmedByUserId

END