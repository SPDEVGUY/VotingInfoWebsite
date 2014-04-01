IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Data].[ElectionLevelMetaDataXref]') AND type in (N'U'))
BEGIN
	CREATE TABLE [Data].[ElectionLevelMetaDataXref](
		[ElectionLevelMetaDataXrefId] int IDENTITY(1,1) NOT NULL,
		[ContentInspectionId] int  NOT NULL,
		[ElectionLevelId] int  NOT NULL,
		[MetaDataId] nchar(10)  NULL,
		CONSTRAINT [PK_ElectionLevelMetaDataXref] PRIMARY KEY CLUSTERED ([ElectionLevelMetaDataXrefId])
	)  
	INSERT INTO [Data].[TableVersion]([TableName],[Version]) VALUES('[Data].[ElectionLevelMetaDataXref]', 0)
END
