IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Data].[CandidateMetaData]') AND type in (N'U'))
BEGIN
	CREATE TABLE [Data].[CandidateMetaData](
		[CandidateMetaDataId] int IDENTITY(1,1) NOT NULL,
		[ContentInspectionId] int  NOT NULL,
		[CandidateId] int  NOT NULL,
		[MetaDataId] int  NOT NULL,
		[MetaDataValue] varchar(max)  NOT NULL,
		CONSTRAINT [PK_CandidateMetaData] PRIMARY KEY CLUSTERED ([CandidateMetaDataId])
	)  
	INSERT INTO [Data].[TableVersion]([TableName],[Version]) VALUES('[Data].[CandidateMetaData]', 0)
END
