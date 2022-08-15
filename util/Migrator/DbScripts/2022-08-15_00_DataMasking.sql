ALTER TABLE [dbo].[User]
ALTER COLUMN [Name] ADD MASKED WITH (FUNCTION = 'default()');

ALTER TABLE [dbo].[User]
ALTER COLUMN [Email] ADD MASKED WITH (FUNCTION = 'default()');

ALTER TABLE [dbo].[User]
ALTER COLUMN [MasterPassword] ADD MASKED WITH (FUNCTION = 'default()');
    
ALTER TABLE [dbo].[User]
ALTER COLUMN [MasterPasswordHint] ADD MASKED WITH (FUNCTION = 'default()');

ALTER TABLE [dbo].[User]
ALTER COLUMN [Culture] ADD MASKED WITH (FUNCTION = 'default()');

ALTER TABLE [dbo].[User]
ALTER COLUMN [SecurityStamp] ADD MASKED WITH (FUNCTION = 'default()');

ALTER TABLE [dbo].[User]
ALTER COLUMN [TwoFactorProviders] ADD MASKED WITH (FUNCTION = 'default()');

ALTER TABLE [dbo].[User]
ALTER COLUMN [TwoFactorRecoveryCode] ADD MASKED WITH (FUNCTION = 'default()');

ALTER TABLE [dbo].[User]
ALTER COLUMN [EquivalentDomains] ADD MASKED WITH (FUNCTION = 'default()');
    
ALTER TABLE [dbo].[User]
ALTER COLUMN [ExcludedGlobalEquivalentDomains] ADD MASKED WITH (FUNCTION = 'default()');
    
ALTER TABLE [dbo].[User]
ALTER COLUMN [Key] ADD MASKED WITH (FUNCTION = 'default()');
    
ALTER TABLE [dbo].[User]
ALTER COLUMN [PublicKey] ADD MASKED WITH (FUNCTION = 'default()');
    
ALTER TABLE [dbo].[User]
ALTER COLUMN [PrivateKey] ADD MASKED WITH (FUNCTION = 'default()');
    
ALTER TABLE [dbo].[User]
ALTER COLUMN [GatewayCustomerId] ADD MASKED WITH (FUNCTION = 'default()');
    
ALTER TABLE [dbo].[User]
ALTER COLUMN [GatewaySubscriptionId] ADD MASKED WITH (FUNCTION = 'default()');
    
ALTER TABLE [dbo].[User]
ALTER COLUMN [ReferenceData] ADD MASKED WITH (FUNCTION = 'default()');
    
ALTER TABLE [dbo].[User]
ALTER COLUMN [LicenseKey] ADD MASKED WITH (FUNCTION = 'default()');
    
ALTER TABLE [dbo].[User]
ALTER COLUMN [Kdf] ADD MASKED WITH (FUNCTION = 'default()');
    
ALTER TABLE [dbo].[User]
ALTER COLUMN [KdfIterations] ADD MASKED WITH (FUNCTION = 'default()');
    
ALTER TABLE [dbo].[User]
ALTER COLUMN [ApiKey] ADD MASKED WITH (FUNCTION = 'default()');
    
ALTER TABLE [dbo].[User]
ALTER COLUMN [UsesKeyConnector] ADD MASKED WITH (FUNCTION = 'default()');