IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Data].[ElectionCandidate]') AND type in (N'U'))
BEGIN
	CREATE TABLE [Data].[ElectionCandidate](
		[ElectionCandidateId] int IDENTITY(1,1) NOT NULL,
		[ContentInspectionId] int  NOT NULL,
		[CandidateId] int  NOT NULL,
		[ElectionId] int  NOT NULL,
		[IsWinner] bit  NOT NULL,
		[ReportedVoteCount] bit  NOT NULL,
		CONSTRAINT [PK_ElectionCandidate] PRIMARY KEY CLUSTERED ([ElectionCandidateId])
	)  
	INSERT INTO [Data].[TableVersion]([TableName],[Version]) VALUES('[Data].[ElectionCandidate]', 0)
END
