-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Candidate_Update]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Candidate_Update]
GO--
CREATE PROCEDURE [Data].[Candidate_Update] 
			@CandidateId int,
			@UserId int,
			@ContentInspectionId int,
			@LocationId int,
			@OrganizationId int,
			@CandidateName varchar(150)
AS --Generated--
BEGIN

	UPDATE	[Data].[Candidate] SET 
			[UserId] = @UserId,
			[ContentInspectionId] = @ContentInspectionId,
			[LocationId] = @LocationId,
			[OrganizationId] = @OrganizationId,
			[CandidateName] = @CandidateName
	WHERE	[CandidateId] = @CandidateId

END