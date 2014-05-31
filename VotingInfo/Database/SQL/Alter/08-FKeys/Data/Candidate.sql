ALTER TABLE [Data].[Candidate]
ADD	CONSTRAINT [FK_Data_Candidate_UserId] FOREIGN KEY ([UserId]) REFERENCES [Auth].[User] ([UserId])

,	CONSTRAINT [FK_Data_Candidate_ContentInspectionId] FOREIGN KEY ([ContentInspectionId]) REFERENCES [Data].[ContentInspection] ([ContentInspectionId])

,	CONSTRAINT [FK_Data_Candidate_LocationId] FOREIGN KEY ([LocationId]) REFERENCES [Data].[Location] ([LocationId])

,	CONSTRAINT [FK_Data_Candidate_OrganizationId] FOREIGN KEY ([OrganizationId]) REFERENCES [Data].[Organization] ([OrganizationId])

