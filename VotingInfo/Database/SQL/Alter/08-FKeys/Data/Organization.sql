ALTER TABLE [Data].[Organization]
ADD	CONSTRAINT [FK_Data_Organization_ContentInspectionId] FOREIGN KEY ([ContentInspectionId]) REFERENCES [Data].[ContentInspection] ([ContentInspectionId])

