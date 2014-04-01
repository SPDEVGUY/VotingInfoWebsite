ALTER TABLE [Data].[Candidate]
ADD	CONSTRAINT [FK_Data_Candidate_ContentInspectionId] FOREIGN KEY ([ContentInspectionId]) REFERENCES [Data].[ContentInspection] ([ContentInspectionId])

,	CONSTRAINT [FK_Data_Candidate_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [Data].[Organization] ([OrganizationId])

