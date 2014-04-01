IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Data].[Organization]') AND type in (N'U'))
BEGIN
	CREATE TABLE [Data].[Organization](
		[OrganizationId] int IDENTITY(1,1) NOT NULL,
		[ContentInspectionId] int  NOT NULL,
		[OrganizationName] varchar(250)  NOT NULL,
		CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED ([OrganizationId])
	)  
	INSERT INTO [Data].[TableVersion]([TableName],[Version]) VALUES('[Data].[Organization]', 0)
END
