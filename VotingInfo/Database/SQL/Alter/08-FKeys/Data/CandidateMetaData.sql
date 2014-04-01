ALTER TABLE [Data].[CandidateMetaData]
ADD	CONSTRAINT [FK_Data_CandidateMetaData_CandidateId] FOREIGN KEY ([CandidateId]) REFERENCES [Data].[Candidate] ([CandidateId])

,	CONSTRAINT [FK_Data_CandidateMetaData_ContentInspectionId] FOREIGN KEY ([ContentInspectionId]) REFERENCES [Data].[ContentInspection] ([ContentInspectionId])

,	CONSTRAINT [FK_Data_CandidateMetaData_MetaDataId] FOREIGN KEY ([MetaDataId]) REFERENCES [Data].[MetaData] ([MetaDataId])

