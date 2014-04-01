ALTER TABLE [Data].[MetaData]
ADD	CONSTRAINT [FK_Data_MetaData_ContentInspectionId] FOREIGN KEY ([ContentInspectionId]) REFERENCES [Data].[ContentInspection] ([ContentInspectionId])

