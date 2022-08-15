CREATE TABLE [dbo].[User] (
    [Id]                              UNIQUEIDENTIFIER NOT NULL,
    [Name]                            NVARCHAR (50)    NULL,
    [Email]                           NVARCHAR (256)   MASKED WITH (FUNCTION = 'default()') NOT NULL,
    [EmailVerified]                   BIT              NOT NULL,
    [MasterPassword]                  NVARCHAR (300)   MASKED WITH (FUNCTION = 'default()') NULL,
    [MasterPasswordHint]              NVARCHAR (50)    MASKED WITH (FUNCTION = 'default()') NULL,
    [Culture]                         NVARCHAR (10)    MASKED WITH (FUNCTION = 'default()') NOT NULL,
    [SecurityStamp]                   NVARCHAR (50)    MASKED WITH (FUNCTION = 'default()') NOT NULL,
    [TwoFactorProviders]              NVARCHAR (MAX)   MASKED WITH (FUNCTION = 'default()') NULL,
    [TwoFactorRecoveryCode]           NVARCHAR (32)    MASKED WITH (FUNCTION = 'default()') NULL,
    [EquivalentDomains]               NVARCHAR (MAX)   MASKED WITH (FUNCTION = 'default()') NULL,
    [ExcludedGlobalEquivalentDomains] NVARCHAR (MAX)   MASKED WITH (FUNCTION = 'default()') NULL,
    [AccountRevisionDate]             DATETIME2 (7)    NOT NULL,
    [Key]                             VARCHAR (MAX)    MASKED WITH (FUNCTION = 'default()') NULL,
    [PublicKey]                       VARCHAR (MAX)    MASKED WITH (FUNCTION = 'default()') NULL,
    [PrivateKey]                      VARCHAR (MAX)    MASKED WITH (FUNCTION = 'default()') NULL,
    [Premium]                         BIT              NOT NULL,
    [PremiumExpirationDate]           DATETIME2 (7)    NULL,
    [RenewalReminderDate]             DATETIME2 (7)    NULL,
    [Storage]                         BIGINT           NULL,
    [MaxStorageGb]                    SMALLINT         NULL,
    [Gateway]                         TINYINT          NULL,
    [GatewayCustomerId]               VARCHAR (50)     MASKED WITH (FUNCTION = 'default()') NULL,
    [GatewaySubscriptionId]           VARCHAR (50)     MASKED WITH (FUNCTION = 'default()') NULL,
    [ReferenceData]                   NVARCHAR (MAX)   MASKED WITH (FUNCTION = 'default()') NULL,
    [LicenseKey]                      VARCHAR (100)    MASKED WITH (FUNCTION = 'default()') NULL,
    [Kdf]                             TINYINT          MASKED WITH (FUNCTION = 'default()') NOT NULL,
    [KdfIterations]                   INT              MASKED WITH (FUNCTION = 'default()') NOT NULL,
    [CreationDate]                    DATETIME2 (7)    NOT NULL,
    [RevisionDate]                    DATETIME2 (7)    NOT NULL,
    [ApiKey]                          VARCHAR (30)     MASKED WITH (FUNCTION = 'default()') NOT NULL,
    [ForcePasswordReset]              BIT              NOT NULL,
    [UsesKeyConnector]                BIT              MASKED WITH (FUNCTION = 'default()') NOT NULL,
    [FailedLoginCount]                INT              NOT NULL,
    [LastFailedLoginDate]             DATETIME2 (7)    NULL,
    [UnknownDeviceVerificationEnabled]  BIT            NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_User_Email]
    ON [dbo].[User]([Email] ASC);

GO
CREATE NONCLUSTERED INDEX [IX_User_Premium_PremiumExpirationDate_RenewalReminderDate]
    ON [dbo].[User]([Premium] ASC, [PremiumExpirationDate] ASC, [RenewalReminderDate] ASC);

