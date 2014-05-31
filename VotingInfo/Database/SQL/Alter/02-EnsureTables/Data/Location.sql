IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Data].[Location]') AND type in (N'U'))
BEGIN
	CREATE TABLE [Data].[Location](
		[LocationId] int IDENTITY(1,1) NOT NULL,
		[ContentInspectionId] int  NOT NULL,
		[LocationName] varchar(150)  NOT NULL,
		CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED ([LocationId])
	)  
	INSERT INTO [Data].[TableVersion]([TableName],[Version]) VALUES('[Data].[Location]', 0)
END
