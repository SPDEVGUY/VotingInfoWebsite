-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Client].[Candidates_Search]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Client].[Candidates_Search]
GO--
CREATE PROCEDURE [Client].[Candidates_Search] 
			@CandidateName varchar(150) = NULL,
			@SourceUrl varchar(250) = NULL
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
	WHERE	(@CandidateName IS NULL OR [CandidateName] LIKE '%' + @CandidateName + '%')
			AND (@SourceUrl IS NULL OR [SourceUrl] LIKE '%' + @SourceUrl + '%')

END