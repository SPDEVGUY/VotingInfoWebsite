IF NOT EXISTS(SELECT * FROM [Data].[Location]) BEGIN

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

	EXEC [Data].[Location_Insert] 
		@ContentInspectionId = @LastId,
		@LocationName = 'Edmonton, Alberta, Canada'


			   
END