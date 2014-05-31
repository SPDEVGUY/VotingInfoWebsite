-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Voter_SelectBy_LocationId]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Voter_SelectBy_LocationId]
GO--
CREATE PROCEDURE [Data].[Voter_SelectBy_LocationId] 
			@LocationId int
AS --Generated--
BEGIN
	SET NOCOUNT ON;

	SELECT	
			[VoterId],
			[UserId],
			[ContentInspectionId],
			[LocationId],
			[VoterName],
			[PostalCode],
			[FavoriteOrganizationId]
	FROM	[Data].[Voter]
	WHERE	[LocationId] = @LocationId

END