IF NOT EXISTS(SELECT * FROM [Data].[Organization]) BEGIN

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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Conservative'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'New Democratic'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Liberal'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Bloc Quebecois'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Green'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Independent'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Chritsian Heritage'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Marxist-Leninist'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Libertarian'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Progressive Canadian'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Rhinoceros'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Pirate'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Communist'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Canadian Action'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Marijuana'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Animal Alliance'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'Western Block'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'United'

		
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

	EXEC [Data].[Organization_Insert] 
		@ContentInspectionId = @LastId,
		@OrganizationName = 'First Peoples Nation'






			   
END