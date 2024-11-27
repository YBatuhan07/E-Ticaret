IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241027132122_InitialCreate'
)
BEGIN
    CREATE TABLE [AppUsers] (
        [Id] int NOT NULL IDENTITY,
        [Name] varchar(50) NOT NULL,
        [Surname] varchar(50) NOT NULL,
        [Email] varchar(50) NOT NULL,
        [Password] varchar(50) NOT NULL,
        [UserName] nvarchar(50) NOT NULL,
        [Phone] varchar(15) NULL,
        [IsActive] bit NOT NULL,
        [IsAdmin] bit NOT NULL,
        [CreateDate] datetime2 NOT NULL,
        [UserGuid] uniqueidentifier NULL,
        CONSTRAINT [PK_AppUsers] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241027132122_InitialCreate'
)
BEGIN
    CREATE TABLE [Brands] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(50) NOT NULL,
        [Description] nvarchar(500) NULL,
        [Logo] nvarchar(100) NULL,
        [IsActive] bit NOT NULL,
        [OrderNo] int NOT NULL,
        [CreateDate] datetime2 NOT NULL,
        CONSTRAINT [PK_Brands] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241027132122_InitialCreate'
)
BEGIN
    CREATE TABLE [Categories] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(50) NOT NULL,
        [Description] nvarchar(500) NULL,
        [Image] nvarchar(100) NULL,
        [IsActive] bit NOT NULL,
        [IsTopMenu] bit NOT NULL,
        [ParentId] int NOT NULL,
        [OrderNo] int NOT NULL,
        [CreateDate] datetime2 NOT NULL,
        CONSTRAINT [PK_Categories] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241027132122_InitialCreate'
)
BEGIN
    CREATE TABLE [Contacts] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(50) NOT NULL,
        [Surname] nvarchar(50) NOT NULL,
        [Phone] varchar(20) NULL,
        [Email] nvarchar(50) NULL,
        [Message] nvarchar(500) NOT NULL,
        [CreateDate] datetime2 NOT NULL,
        CONSTRAINT [PK_Contacts] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241027132122_InitialCreate'
)
BEGIN
    CREATE TABLE [News] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(50) NOT NULL,
        [Description] nvarchar(500) NULL,
        [Image] nvarchar(50) NULL,
        [IsActive] bit NOT NULL,
        [CreateDate] datetime2 NOT NULL,
        CONSTRAINT [PK_News] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241027132122_InitialCreate'
)
BEGIN
    CREATE TABLE [Sliders] (
        [Id] int NOT NULL IDENTITY,
        [Title] nvarchar(500) NULL,
        [Description] nvarchar(500) NULL,
        [Image] nvarchar(500) NULL,
        [Link] nvarchar(500) NULL,
        CONSTRAINT [PK_Sliders] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241027132122_InitialCreate'
)
BEGIN
    CREATE TABLE [Products] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(50) NOT NULL,
        [Description] nvarchar(500) NULL,
        [Image] nvarchar(50) NULL,
        [Price] decimal(18,2) NOT NULL,
        [ProductCode] nvarchar(50) NULL,
        [Stock] int NOT NULL,
        [IsActive] bit NOT NULL,
        [IsHome] bit NOT NULL,
        [CategoryId] int NULL,
        [BrandId] int NULL,
        [OrderNo] int NOT NULL,
        [CreateDate] datetime2 NOT NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Products_Brands_BrandId] FOREIGN KEY ([BrandId]) REFERENCES [Brands] ([Id]),
        CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id])
    );
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241027132122_InitialCreate'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreateDate', N'Email', N'IsActive', N'IsAdmin', N'Name', N'Password', N'Phone', N'Surname', N'UserGuid', N'UserName') AND [object_id] = OBJECT_ID(N'[AppUsers]'))
        SET IDENTITY_INSERT [AppUsers] ON;
    EXEC(N'INSERT INTO [AppUsers] ([Id], [CreateDate], [Email], [IsActive], [IsAdmin], [Name], [Password], [Phone], [Surname], [UserGuid], [UserName])
    VALUES (1, ''2024-10-27T16:21:21.7635151+03:00'', ''admin@gmail.com'', CAST(1 AS bit), CAST(1 AS bit), ''admin'', ''123456'', NULL, ''admin'', ''da16958a-7694-4c05-880a-59a5430b4911'', N''admin'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreateDate', N'Email', N'IsActive', N'IsAdmin', N'Name', N'Password', N'Phone', N'Surname', N'UserGuid', N'UserName') AND [object_id] = OBJECT_ID(N'[AppUsers]'))
        SET IDENTITY_INSERT [AppUsers] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241027132122_InitialCreate'
)
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreateDate', N'Description', N'Image', N'IsActive', N'IsTopMenu', N'Name', N'OrderNo', N'ParentId') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] ON;
    EXEC(N'INSERT INTO [Categories] ([Id], [CreateDate], [Description], [Image], [IsActive], [IsTopMenu], [Name], [OrderNo], [ParentId])
    VALUES (1, ''2024-10-27T16:21:21.7638305+03:00'', NULL, NULL, CAST(1 AS bit), CAST(1 AS bit), N''Elektronik'', 1, 0),
    (2, ''2024-10-27T16:21:21.7638313+03:00'', NULL, NULL, CAST(1 AS bit), CAST(1 AS bit), N''Bilgisayar'', 2, 0)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreateDate', N'Description', N'Image', N'IsActive', N'IsTopMenu', N'Name', N'OrderNo', N'ParentId') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] OFF;
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241027132122_InitialCreate'
)
BEGIN
    CREATE INDEX [IX_Products_BrandId] ON [Products] ([BrandId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241027132122_InitialCreate'
)
BEGIN
    CREATE INDEX [IX_Products_CategoryId] ON [Products] ([CategoryId]);
END;
GO

IF NOT EXISTS (
    SELECT * FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20241027132122_InitialCreate'
)
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20241027132122_InitialCreate', N'8.0.11');
END;
GO

COMMIT;
GO

