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

CREATE TABLE [Login] (
    [CodLogin] nvarchar(450) NOT NULL,
    [Email] nvarchar(50) NOT NULL,
    [Senha] CHAR(8) NOT NULL,
    CONSTRAINT [PK_Login] PRIMARY KEY ([CodLogin])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211220233152_Migrations', N'5.0.13');
GO

COMMIT;
GO

