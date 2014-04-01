ALTER TABLE [Data].[ElectionLevel]
ADD	CONSTRAINT [FK_Data_ElectionLevel_ContentInspectionId] FOREIGN KEY ([ContentInspectionId]) REFERENCES [Data].[ContentInspection] ([ContentInspectionId])

