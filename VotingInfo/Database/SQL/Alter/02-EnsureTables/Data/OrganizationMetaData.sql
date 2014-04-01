IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Data].[OrganizationMetaData]') AND type in (N'U'))
BEGIN
	CREATE TABLE [Data].[OrganizationMetaData](
		[OrganizationMetaDataId] int IDENTITY(1,1) NOT NULL,
		[ContentInspectionId] int  NOT NULL,
		[OrganizationId] int  NOT NULL,
		[MetaDataId] int  NOT NULL,
		[MetaDataValue] varchar(max)  NOT NULL,
		CONSTRAINT [PK_OrganizationMetaData] PRIMARY KEY CLUSTERED ([OrganizationMetaDataId])
	)  
	INSERT INTO [Data].[TableVersion]([TableName],[Version]) VALUES('[Data].[OrganizationMetaData]', 0)
END
