IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Data].[Election]') AND type in (N'U'))
BEGIN
	CREATE TABLE [Data].[Election](
		[ElectionId] int IDENTITY(1,1) NOT NULL,
		[ContentInspectionId] int  NOT NULL,
		[ElectionLevelId] int  NOT NULL,
		[ElectionRegion] varchar(150)  NOT NULL,
		[VotingDate] datetime  NOT NULL,
		CONSTRAINT [PK_Election] PRIMARY KEY CLUSTERED ([ElectionId])
	)  
	INSERT INTO [Data].[TableVersion]([TableName],[Version]) VALUES('[Data].[Election]', 0)
END
