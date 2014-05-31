-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[Election_Update]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[Election_Update]
GO--
CREATE PROCEDURE [Data].[Election_Update] 
			@ElectionId int,
			@ContentInspectionId int,
			@ElectionLevelId int,
			@LocationId int,
			@VotingDate datetime
AS --Generated--
BEGIN

	UPDATE	[Data].[Election] SET 
			[ContentInspectionId] = @ContentInspectionId,
			[ElectionLevelId] = @ElectionLevelId,
			[LocationId] = @LocationId,
			[VotingDate] = @VotingDate
	WHERE	[ElectionId] = @ElectionId

END