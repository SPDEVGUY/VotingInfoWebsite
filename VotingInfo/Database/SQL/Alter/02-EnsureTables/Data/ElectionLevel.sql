IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Data].[ElectionLevel]') AND type in (N'U'))
BEGIN
	CREATE TABLE [Data].[ElectionLevel](
		[ElectionLevelId] int IDENTITY(1,1) NOT NULL,
		[ContentInspectionId] int  NOT NULL,
		[ElectionLevelTitle] varchar(150)  NOT NULL,
		CONSTRAINT [PK_ElectionLevel] PRIMARY KEY CLUSTERED ([ElectionLevelId])
	)  
	INSERT INTO [Data].[TableVersion]([TableName],[Version]) VALUES('[Data].[ElectionLevel]', 0)
END
