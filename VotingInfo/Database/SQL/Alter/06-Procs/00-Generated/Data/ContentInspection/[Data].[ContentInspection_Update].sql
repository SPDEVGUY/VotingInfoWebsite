-----------------------------------------------------------------------------------
--Do not modify this file, instead use an alter proc to over-write the procedure.--
--Make sure you follow the same expected interface of parameters, and resultsets.--
-----------------------------------------------------------------------------------

IF EXISTS(SELECT * FROM [dbo].[sysobjects] WHERE ID=object_id(N'[Data].[ContentInspection_Update]') AND OBJECTPROPERTY(id, N'IsProcedure')=1) DROP PROC [Data].[ContentInspection_Update]
GO--
CREATE PROCEDURE [Data].[ContentInspection_Update] 
			@ContentInspectionId int,
			@IsArchived bit,
			@IsBeingProposed bit,
			@ProposedByUserId int,
			@ConfirmedByUserId int,
			@FalseInfoCount int,
			@TrueInfoCount int,
			@AdminInpsected bit,
			@DateLastChecked datetime,
			@SourceUrl varchar(250)
AS --Generated--
BEGIN

	UPDATE	[Data].[ContentInspection] SET 
			[IsArchived] = @IsArchived,
			[IsBeingProposed] = @IsBeingProposed,
			[ProposedByUserId] = @ProposedByUserId,
			[ConfirmedByUserId] = @ConfirmedByUserId,
			[FalseInfoCount] = @FalseInfoCount,
			[TrueInfoCount] = @TrueInfoCount,
			[AdminInpsected] = @AdminInpsected,
			[DateLastChecked] = @DateLastChecked,
			[SourceUrl] = @SourceUrl
	WHERE	[ContentInspectionId] = @ContentInspectionId

END