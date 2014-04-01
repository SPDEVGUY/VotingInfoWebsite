IF NOT EXISTS(SELECT * FROM [Data].[MetaData]) BEGIN

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
			@SourceUrl = 'http://www.facebook.com'
	SELECT TOP 1 @LastId = [ContentInspectionId] FROM [Data].[ContentInspection] ORDER BY [ContentInspectionId] DESC

	EXEC [Data].[MetaData_Insert]
			@ContentInspectionId = @LastId,
			@MetaDataName = 'Facebook Page',
			@IsRequired = 0,
			@AppliesAtAllLevels = 1,
			@AppliesToCandidates = 1,
			@AppliesToOrganizations =1


	
	EXEC [Data].[ContentInspection_Insert]
			@IsArchived =0,
			@IsBeingProposed =0,
			@ProposedByUserId =1,
			@ConfirmedByUserId =1,
			@FalseInfoCount =0,
			@TrueInfoCount =1,
			@AdminInpsected =0,
			@DateLastChecked =@Now,
			@SourceUrl = 'http://www.twitter.com'
	SELECT TOP 1 @LastId = [ContentInspectionId] FROM [Data].[ContentInspection] ORDER BY [ContentInspectionId] DESC

	EXEC [Data].[MetaData_Insert]
			@ContentInspectionId = @LastId,
			@MetaDataName = 'Twitter',
			@IsRequired = 0,
			@AppliesAtAllLevels = 1,
			@AppliesToCandidates = 1,
			@AppliesToOrganizations =1

			
	EXEC [Data].[ContentInspection_Insert]
			@IsArchived =0,
			@IsBeingProposed =0,
			@ProposedByUserId =1,
			@ConfirmedByUserId =1,
			@FalseInfoCount =0,
			@TrueInfoCount =1,
			@AdminInpsected =0,
			@DateLastChecked =@Now,
			@SourceUrl = 'http://www.youtube.com'
	SELECT TOP 1 @LastId = [ContentInspectionId] FROM [Data].[ContentInspection] ORDER BY [ContentInspectionId] DESC

	EXEC [Data].[MetaData_Insert]
			@ContentInspectionId = @LastId,
			@MetaDataName = 'YouTube Channel',
			@IsRequired = 0,
			@AppliesAtAllLevels = 1,
			@AppliesToCandidates = 1,
			@AppliesToOrganizations =1

			
	EXEC [Data].[ContentInspection_Insert]
			@IsArchived =0,
			@IsBeingProposed =0,
			@ProposedByUserId =1,
			@ConfirmedByUserId =1,
			@FalseInfoCount =0,
			@TrueInfoCount =1,
			@AdminInpsected =0,
			@DateLastChecked =@Now,
			@SourceUrl = ''
	SELECT TOP 1 @LastId = [ContentInspectionId] FROM [Data].[ContentInspection] ORDER BY [ContentInspectionId] DESC

	EXEC [Data].[MetaData_Insert]
			@ContentInspectionId = @LastId,
			@MetaDataName = 'Platform Summary',
			@IsRequired = 1,
			@AppliesAtAllLevels = 1,
			@AppliesToCandidates = 1,
			@AppliesToOrganizations =1
			
	EXEC [Data].[ContentInspection_Insert]
			@IsArchived =0,
			@IsBeingProposed =0,
			@ProposedByUserId =1,
			@ConfirmedByUserId =1,
			@FalseInfoCount =0,
			@TrueInfoCount =1,
			@AdminInpsected =0,
			@DateLastChecked =@Now,
			@SourceUrl = 'http://www.wikipedia.com'
	SELECT TOP 1 @LastId = [ContentInspectionId] FROM [Data].[ContentInspection] ORDER BY [ContentInspectionId] DESC


	EXEC [Data].[MetaData_Insert]
			@ContentInspectionId = @LastId,
			@MetaDataName = 'Wikipedia Article',
			@IsRequired = 1,
			@AppliesAtAllLevels = 1,
			@AppliesToCandidates = 1,
			@AppliesToOrganizations =1

	EXEC [Data].[ContentInspection_Insert]
			@IsArchived =0,
			@IsBeingProposed =0,
			@ProposedByUserId =1,
			@ConfirmedByUserId =1,
			@FalseInfoCount =0,
			@TrueInfoCount =1,
			@AdminInpsected =0,
			@DateLastChecked =@Now,
			@SourceUrl = ''
	SELECT TOP 1 @LastId = [ContentInspectionId] FROM [Data].[ContentInspection] ORDER BY [ContentInspectionId] DESC

	EXEC [Data].[MetaData_Insert]
			@ContentInspectionId = @LastId,
			@MetaDataName = 'Platform Website',
			@IsRequired = 1,
			@AppliesAtAllLevels = 1,
			@AppliesToCandidates = 1,
			@AppliesToOrganizations =1
			   
END