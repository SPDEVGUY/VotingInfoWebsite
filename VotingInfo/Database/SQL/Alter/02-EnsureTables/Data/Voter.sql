IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Data].[Voter]') AND type in (N'U'))
BEGIN
	CREATE TABLE [Data].[Voter](
		[VoterId] int IDENTITY(1,1) NOT NULL,
		[UserId] int  NOT NULL,
		[ContentInspectionId] int  NOT NULL,
		[LocationId] int  NOT NULL,
		[VoterName] varchar(150)  NOT NULL,
		[PostalCode] char(6)  NOT NULL,
		[FavoriteOrganizationId] int  NOT NULL,
		CONSTRAINT [PK_Voter] PRIMARY KEY CLUSTERED ([VoterId])
	)  
	INSERT INTO [Data].[TableVersion]([TableName],[Version]) VALUES('[Data].[Voter]', 0)
END
