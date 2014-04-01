ALTER TABLE [Data].[ElectionCandidate]
ADD	CONSTRAINT [FK_Data_ElectionCandidate_CandidateId] FOREIGN KEY ([CandidateId]) REFERENCES [Data].[Candidate] ([CandidateId])

,	CONSTRAINT [FK_Data_ElectionCandidate_ContentInspectionId] FOREIGN KEY ([ContentInspectionId]) REFERENCES [Data].[ContentInspection] ([ContentInspectionId])

,	CONSTRAINT [FK_Data_ElectionCandidate_ElectionId] FOREIGN KEY ([ElectionId]) REFERENCES [Data].[Election] ([ElectionId])

