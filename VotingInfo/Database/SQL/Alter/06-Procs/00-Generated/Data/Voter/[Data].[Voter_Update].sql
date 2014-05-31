-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Voter_Update]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Voter_Update]
GO--
CREATE PROCEDURE [Data].[Voter_Update] 
			@VoterId int,
			@UserId int,
			@ContentInspectionId int,
			@LocationId int,
			@VoterName varchar(150),
			@PostalCode char(6),
			@FavoriteOrganizationId int
AS --Generated--
BEGIN

	UPDATE	[Data].[Voter] SET 
			[UserId] = @UserId,
			[ContentInspectionId] = @ContentInspectionId,
			[LocationId] = @LocationId,
			[VoterName] = @VoterName,
			[PostalCode] = @PostalCode,
			[FavoriteOrganizationId] = @FavoriteOrganizationId
	WHERE	[VoterId] = @VoterId

END