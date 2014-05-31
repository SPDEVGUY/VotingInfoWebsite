ALTER TABLE [Data].[Location]
ADD	CONSTRAINT [FK_Data_Location_ContentInspectionId] FOREIGN KEY ([ContentInspectionId]) REFERENCES [Data].[ContentInspection] ([ContentInspectionId])

