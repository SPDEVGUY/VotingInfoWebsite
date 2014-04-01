IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Data].[Candidate]') AND type in (N'U'))
BEGIN
	CREATE TABLE [Data].[Candidate](
		[CandidateId] int IDENTITY(1,1) NOT NULL,
		[ContentInspectionId] int  NOT NULL,
		[CandidateName] varchar(150)  NOT NULL,
		[OrganizationId] int  NOT NULL,
		CONSTRAINT [PK_Candidate] PRIMARY KEY CLUSTERED ([CandidateId])
	)  
	INSERT INTO [Data].[TableVersion]([TableName],[Version]) VALUES('[Data].[Candidate]', 0)
END
