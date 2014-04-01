-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Client].[Organizations_SelectBy_ProposedByUserId]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Client].[Organizations_SelectBy_ProposedByUserId]
GO--
CREATE PROCEDURE [Client].[Organizations_SelectBy_ProposedByUserId] 
			@ProposedByUserId int
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[OrganizationId],
			[ContentInspectionId],
			[OrganizationName],
			[IsArchived],
			[IsBeingProposed],
			[ProposedByUserId],
			[ConfirmedByUserId],
			[FalseInfoCount],
			[TrueInfoCount],
			[AdminInpsected],
			[DateLastChecked],
			[SourceUrl]
	FROM	[Client].[Organizations]
	WHERE	[ProposedByUserId] = @ProposedByUserId

END