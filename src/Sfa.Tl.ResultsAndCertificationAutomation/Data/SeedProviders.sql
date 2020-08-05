SET IDENTITY_INSERT [dbo].[TlProvider] ON

MERGE INTO [dbo].[TlProvider] AS Target 
USING (VALUES 
(100001,99999998,'Hello college','Hello college'))
AS Source ([Id], [UkPrn], [Name], [DisplayName]) 
ON Target.[Id] = Source.[Id] 
-- Update from Source when Id is Matched
WHEN MATCHED 
	 AND ((Target.[UkPrn] <> Source.[UkPrn])
	   OR (Target.[Name] <> Source.[Name] COLLATE Latin1_General_CS_AS)
	   OR (Target.[DisplayName] <> Source.[DisplayName] COLLATE Latin1_General_CS_AS))
THEN 
UPDATE SET 
	[UkPrn] = Source.[UkPrn],
	[Name] = Source.[Name],
	[DisplayName] = Source.[DisplayName],
	[ModifiedOn] = GETDATE(),
	[ModifiedBy] = 'System'
WHEN NOT MATCHED BY TARGET THEN 
	INSERT ([Id], [UkPrn], [Name], [DisplayName], [CreatedBy]) 
	VALUES ([Id], [UkPrn], [Name], [DisplayName], 'System');

SET IDENTITY_INSERT [dbo].[TlProvider] OFF