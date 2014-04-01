IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Data].[MetaData]') AND type in (N'U'))
BEGIN
	CREATE TABLE [Data].[MetaData](
		[MetaDataId] int IDENTITY(1,1) NOT NULL,
		[ContentInspectionId] int  NOT NULL,
		[MetaDataName] varchar(150)  NOT NULL,
		[IsRequired] bit  NOT NULL,
		[AppliesAtAllLevels] bit  NOT NULL,
		[AppliesToCandidates] bit  NOT NULL,
		[AppliesToOrganizations] bit  NOT NULL,
		CONSTRAINT [PK_MetaData] PRIMARY KEY CLUSTERED ([MetaDataId])
	)  
	INSERT INTO [Data].[TableVersion]([TableName],[Version]) VALUES('[Data].[MetaData]', 0)
END
