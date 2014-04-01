IF NOT EXISTS(SELECT * FROM [Data].[ElectionLevel]) BEGIN

	DECLARE @Now DateTime; SET @Now = GETDATE();
	DECLARE @LastId int;

	EXEC [Data].[ContentInspection_Insert]
			@IsArchived =0,
			@IsBeingProposed =0,
			@ProposedByUserId =1,
			@ConfirmedByUserId =1,
			@FalseInfoCount =0,
			@TrueInfoCount =1,
			@AdminInpsected =0,
			@DateLastChecked =@Now,
			@SourceUrl = 'http://en.wikipedia.org/wiki/Elections_in_Canada'
	SELECT TOP 1 @LastId = [ContentInspectionId] FROM [Data].[ContentInspection] ORDER BY [ContentInspectionId] DESC

	EXEC [Data].[ElectionLevel_Insert] 
		@ContentInspectionId = @LastId,
		@ElectionLevelTitle = 'Canada - Federal / National Elections'


	EXEC [Data].[ContentInspection_Insert]
			@IsArchived =0,
			@IsBeingProposed =0,
			@ProposedByUserId =1,
			@ConfirmedByUserId =1,
			@FalseInfoCount =0,
			@TrueInfoCount =1,
			@AdminInpsected =0,
			@DateLastChecked =@Now,
			@SourceUrl = 'http://en.wikipedia.org/wiki/Elections_in_Canada'
	SELECT TOP 1 @LastId = [ContentInspectionId] FROM [Data].[ContentInspection] ORDER BY [ContentInspectionId] DESC

	EXEC [Data].[ElectionLevel_Insert] 
		@ContentInspectionId = @LastId,
		@ElectionLevelTitle = 'Canada - Provincial / Territorial Elections'


	EXEC [Data].[ContentInspection_Insert]
			@IsArchived =0,
			@IsBeingProposed =0,
			@ProposedByUserId =1,
			@ConfirmedByUserId =1,
			@FalseInfoCount =0,
			@TrueInfoCount =1,
			@AdminInpsected =0,
			@DateLastChecked =@Now,
			@SourceUrl = 'http://en.wikipedia.org/wiki/Municipal_elections_in_Canada'
	SELECT TOP 1 @LastId = [ContentInspectionId] FROM [Data].[ContentInspection] ORDER BY [ContentInspectionId] DESC

	EXEC [Data].[ElectionLevel_Insert] 
		@ContentInspectionId = @LastId,
		@ElectionLevelTitle = 'Canada - Municipal Elections'
		

	EXEC [Data].[ContentInspection_Insert]
			@IsArchived =0,
			@IsBeingProposed =0,
			@ProposedByUserId =1,
			@ConfirmedByUserId =1,
			@FalseInfoCount =0,
			@TrueInfoCount =1,
			@AdminInpsected =0,
			@DateLastChecked =@Now,
			@SourceUrl = 'http://en.wikipedia.org/wiki/Elections_in_Canada'
	SELECT TOP 1 @LastId = [ContentInspectionId] FROM [Data].[ContentInspection] ORDER BY [ContentInspectionId] DESC

	EXEC [Data].[ElectionLevel_Insert] 
		@ContentInspectionId = @LastId,
		@ElectionLevelTitle = 'Canada - Provincial Senate Nominations'

		
	EXEC [Data].[ContentInspection_Insert]
			@IsArchived =0,
			@IsBeingProposed =0,
			@ProposedByUserId =1,
			@ConfirmedByUserId =1,
			@FalseInfoCount =0,
			@TrueInfoCount =1,
			@AdminInpsected =0,
			@DateLastChecked =@Now,
			@SourceUrl = 'http://en.wikipedia.org/wiki/Elections_in_Canada'
	SELECT TOP 1 @LastId = [ContentInspectionId] FROM [Data].[ContentInspection] ORDER BY [ContentInspectionId] DESC

	EXEC [Data].[ElectionLevel_Insert] 
		@ContentInspectionId = @LastId,
		@ElectionLevelTitle = 'Canada - City Mayors'
		
	EXEC [Data].[ContentInspection_Insert]
			@IsArchived =0,
			@IsBeingProposed =0,
			@ProposedByUserId =1,
			@ConfirmedByUserId =1,
			@FalseInfoCount =0,
			@TrueInfoCount =1,
			@AdminInpsected =0,
			@DateLastChecked =@Now,
			@SourceUrl = 'http://en.wikipedia.org/wiki/Elections_in_Canada'
	SELECT TOP 1 @LastId = [ContentInspectionId] FROM [Data].[ContentInspection] ORDER BY [ContentInspectionId] DESC

	EXEC [Data].[ElectionLevel_Insert] 
		@ContentInspectionId = @LastId,
		@ElectionLevelTitle = 'Canada - City District Wards'
			   
END