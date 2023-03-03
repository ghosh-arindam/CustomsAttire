USE [master]
GO

-- Database
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'CustomsAttire')
CREATE DATABASE [CustomsAttire];
GO

USE [CustomsAttire];
GO

-- Tables
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[HumanResources].[Employee]') AND type in (N'U'))
CREATE TABLE [HumanResources].[Employee](
	[ID] [uniqueidentifier] NOT NULL DEFAULT (NEWSEQUENTIALID()),
	[BusinessEntityID] [int] NOT NULL,
	[NationalIDNumber] [nvarchar](20) NULL,
	[LoginID] [nvarchar](256) NULL,
	[JobTitle] [nvarchar](50) NULL,
	[BirthDate] [date] NULL,
	[MaritalStatus] [nchar](1) NULL,
	[Gender] [nchar](1) NULL,
	[HireDate] [date] NULL,
	[SalariedFlag] [dbo].[Flag] NULL,
	[VacationHours] [smallint] NULL,
	[SickLeaveHours] [smallint] NULL,
	[CurrentFlag] [dbo].[Flag] NULL,
	[rowguid] [uniqueidentifier] NULL,
	[CreatedBy] [varchar](20) NULL,
	[CreatedDate] datetimeoffset NOT NULL DEFAULT (SYSUTCDATETIME()),
	[ModifiedBy] [varchar](20) NULL,
	[ModifiedDate] datetimeoffset NOT NULL DEFAULT (SYSUTCDATETIME()),
 CONSTRAINT [PK_Employee_BusinessEntityID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[BusinessEntityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Production].[POSReport]') AND type in (N'U'))
CREATE TABLE [Production].[POSReport] (
	Id [uniqueidentifier] NOT NULL DEFAULT (NEWSEQUENTIALID()),
	Opening_Cash_in_Hand decimal(10,2) NOT NULL,
	Expense_Type varchar(255) NOT NULL,
	Expense_Description varchar(255) NOT NULL,
	Expense_Amt decimal(10,2) NOT NULL,
	Cash_Deposit_in_Bank decimal(10,2) NOT NULL,
	Money_received_from_Customer decimal(10,2) NOT NULL,
	Closing_Cash_Balance AS (isnull([Opening_Cash_in_Hand]+[Cash_Deposit_in_Bank]+[Money_received_from_Customer]-[Expense_Amt],(0.00))),
	[CreatedBy] [varchar](20) NULL,
	[CreatedDate] datetimeoffset NOT NULL DEFAULT (SYSUTCDATETIME()),
	[ModifiedBy] [varchar](20) NULL,
	[ModifiedDate] datetimeoffset NOT NULL DEFAULT (SYSUTCDATETIME()),
  CONSTRAINT [PK_CUSTOMS_ATTIREPOSREPORT] PRIMARY KEY CLUSTERED
  (
  [Id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)
);
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Person].[User]') AND type in (N'U'))
CREATE TABLE [Person].[User] (
    [Id] uniqueidentifier NOT NULL DEFAULT (NEWSEQUENTIALID()),
    [EmailAddress] nvarchar(256) NOT NULL,
    [IsEmailAddressConfirmed] bit NOT NULL DEFAULT (0),
    [DisplayName] nvarchar(256) NOT NULL,
    [PasswordHash] nvarchar(MAX) NULL,
    [ResetHash] nvarchar(MAX) NULL,
    [InviteHash] nvarchar(MAX) NULL,
    [AccessFailedCount] int NOT NULL DEFAULT (0),
    [LockoutEnabled] bit NOT NULL DEFAULT (0),
    [LockoutEnd] datetimeoffset NULL,
    [LastLogin] datetimeoffset NULL,
    [IsDeleted] bit NOT NULL DEFAULT (0),
    [CreatedBy] [varchar](20) NULL,
	[CreatedDate] datetimeoffset NOT NULL DEFAULT (SYSUTCDATETIME()),
	[ModifiedBy] [varchar](20) NULL,
	[ModifiedDate] datetimeoffset NOT NULL DEFAULT (SYSUTCDATETIME()),
    CONSTRAINT [PK_User] PRIMARY KEY ([Id])
);

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Person].[UserLogin]') AND type in (N'U'))
CREATE TABLE [Person].[UserLogin](
	[Id] [uniqueidentifier] NOT NULL DEFAULT (NEWSEQUENTIALID()),
	[EmailAddress] [nvarchar](256) NOT NULL,
	[UserId] [varchar](50) NULL,
	[UserAgent] [nvarchar](max) NULL,
	[Browser] [nvarchar](256) NULL,
	[OperatingSystem] [nvarchar](256) NULL,
	[DeviceFamily] [nvarchar](256) NULL,
	[DeviceBrand] [nvarchar](256) NULL,
	[DeviceModel] [nvarchar](256) NULL,
	[IpAddress] [nvarchar](50) NULL,
	[IsSuccessful] [bit] NOT NULL DEFAULT ((0)),
	[FailureMessage] [nvarchar](256) NULL,
	[CreatedBy] [varchar](20) NULL,
	[CreatedDate] [datetimeoffset](7) NOT NULL DEFAULT (SYSUTCDATETIME()),
	[ModifiedBy] [varchar](20) NULL,
	[ModifiedDate] [datetimeoffset](7) NOT NULL DEFAULT (SYSUTCDATETIME()),
 CONSTRAINT [PK_UserLogin] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Person].[UserRole]') AND type in (N'U'))
CREATE TABLE [Person].[UserRole] (
    [Id] uniqueidentifier NOT NULL DEFAULT (NEWSEQUENTIALID()),
    [UserId] uniqueidentifier NOT NULL,
    [Role] uniqueidentifier NOT NULL,
	[CreatedBy] [varchar](20) NULL,
	[CreatedDate] datetimeoffset NOT NULL DEFAULT (SYSUTCDATETIME()),
	[ModifiedBy] [varchar](20) NULL,
	[ModifiedDate] datetimeoffset NOT NULL DEFAULT (SYSUTCDATETIME()),
    CONSTRAINT [PK_UserRole] PRIMARY KEY ([UserId], [RoleId])
);
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Person].[Customer]') AND type in (N'U'))
CREATE TABLE [Person].[Customer](
	[Id] [uniqueidentifier] NOT NULL DEFAULT (NEWSEQUENTIALID()),
	[Title] [nvarchar](10) NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[PhoneNo] [nchar](15) NOT NULL,
	[EmailId] [varchar](255) NOT NULL,
	[DOB] [date] NULL,
	[Gender] [nchar](1) NOT NULL,
	[Address1] [varchar](255) NOT NULL,
	[Address2] [varchar](max) NOT NULL,
	[AnniversaryDate] [date] NULL,
	[CreatedBy] [varchar](20) NULL,
	[CreatedDate] [datetimeoffset](7) NOT NULL DEFAULT (SYSUTCDATETIME()),
	[ModifiedBy] [varchar](20) NULL,
	[ModifiedDate] [datetimeoffset](7) NOT NULL DEFAULT (SYSUTCDATETIME()),
 CONSTRAINT [PK_CUSTOMS_ATTIRECUSTOMER] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[Purchasing].[PurchaseOrders]') AND type in (N'U'))
CREATE TABLE [Purchasing].[PurchaseOrders](
	[Id] [uniqueidentifier] NOT NULL DEFAULT (NEWSEQUENTIALID()),
	[fabricCode] [nvarchar](max) NOT NULL,
	[quantityPurchased] [bigint] NOT NULL DEFAULT 1,
	[units] [nvarchar](10) NULL,
	[costPrice] [decimal](10, 2) NOT NULL DEFAULT 0.00,
	[totalCostPrice]  AS (isnull([quantityPurchased]*[costPrice],(0.00))),
	[paymentmode] [nvarchar](10) NULL,
	[paymentdone] [decimal](10, 2) NULL DEFAULT 0.00,
	[duepayment]  AS (isnull([quantityPurchased]*[costPrice]-[paymentdone],(0.00))),
	[purchasedate] [datetime] NULL DEFAULT (((1)/(1))/(1900)),
	[CreatedDate] [datetimeoffset](7) NOT NULL,
	[CreatedBy] [varchar](20) NULL,
	[ModifiedDate] [datetimeoffset](7) NOT NULL,
	[ModifiedBy] [varchar](20) NULL,
 CONSTRAINT [PK_Purchasing.PurchaseOrders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Person].[FK_UserLogin_User_UserId]') AND parent_object_id = OBJECT_ID(N'[Person].[UserLogin]'))
ALTER TABLE [Person].[UserLogin]
    ADD CONSTRAINT [FK_UserLogin_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [Person].[User] ([Id]);

IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[Person].[FK_UserRole_User_UserId]') AND parent_object_id = OBJECT_ID(N'[Person].[UserRole]'))
ALTER TABLE [Person].[UserRole]
    ADD CONSTRAINT [FK_UserRole_User_UserId] FOREIGN KEY ([UserId]) REFERENCES [Person].[User] ([Id]);

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[Person].[User]') AND name = N'UX_User_EmailAddress')
CREATE UNIQUE INDEX [UX_User_EmailAddress]
ON [Person].[User] ([EmailAddress]);

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[Person].[UserLogin]') AND name = N'IX_UserLogin_EmailAddress')
CREATE INDEX [IX_UserLogin_EmailAddress]
ON [Person].[UserLogin] ([EmailAddress]);

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[Person].[UserLogin]') AND name = N'IX_UserLogin_UserId')
CREATE INDEX [IX_UserLogin_UserId]
ON [Person].[UserLogin] ([UserId]);

