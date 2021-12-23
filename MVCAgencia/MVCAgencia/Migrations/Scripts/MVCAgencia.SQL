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

CREATE TABLE [Clientes] (
    [CodCliente] int NOT NULL IDENTITY,
    [NomeCompleto] nvarchar(50) NOT NULL,
    [CPF] char(11) NOT NULL,
    [RG] nvarchar(10) NOT NULL,
    [Nascimento] date NOT NULL,
    CONSTRAINT [PK_Clientes] PRIMARY KEY ([CodCliente])
);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20211222215618_MVCAgencia', N'5.0.13');
GO

COMMIT;
GO

