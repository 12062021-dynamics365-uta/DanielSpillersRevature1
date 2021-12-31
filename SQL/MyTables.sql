CREATE DATABASE PROJECT_0
GO
USE PROJECT_0
Go

--Create Tables--
CREATE TABLE [dbo].[Customer]
(
	[CustomerId] INT NOT NULL,
    [FirstName] NVARCHAR(40) NOT NULL,
    [LastName] NVARCHAR(20) NOT NULL,
	[UserName] NVARCHAR(20) NOT NULL,
	[Email] NVARCHAR(60) NOT NULL,
	[Password]NVARCHAR(20) NOT NULL,
	CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED ([CustomerId])
);
GO
CREATE TABLE [dbo].[Invoice]
(
    [InvoiceId] INT NOT NULL,
    [CustomerId] INT NOT NULL,
    [InvoiceDate] DATETIME NOT NULL,
	[Total] NUMERIC(10,2) NOT NULL,
	CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED ([InvoiceId])
);
GO
CREATE TABLE [dbo].[InvoiceLine]
(
	[InvoiceLineId] INT NOT NULL,
    [InvoiceId] INT NOT NULL,
    [ProductId] INT NOT NULL,
	[Description] NVARCHAR(70) NOT NULL,
    [Price] NUMERIC(10,2) NOT NULL,
    [Quantity] INT NOT NULL,
    CONSTRAINT [PK_InvoiceLine] PRIMARY KEY CLUSTERED ([InvoiceLineId])
);
GO
CREATE TABLE [dbo].[Products]
(
	[ProductId] INT NOT NULL,
	[ProductName] NVARCHAR(50) NOT NULL,
	[Description] NVARCHAR(70) NOT NULL,
	[Price] NUMERIC(10,2) NOT NULL,
	CONSTRAINT [PK_ProductId] PRIMARY KEY CLUSTERED ([ProductId])
);
GO

--Create Foreign Keys--
ALTER TABLE [dbo].[Invoices] ADD CONSTRAINT [FK_InvoiceCustomerId]
	FOREIGN KEY ([CustomerId]) REFERENCES [dbo].[Customer] ([CustomerId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE [dbo].[InvoiceLines] ADD CONSTRAINT [FK_InvoiceLineInvoiceId]
	FOREIGN KEY ([InvoiceId]) REFERENCES [dbo].[Invoice] ([InvoiceId]) ON DELETE NO ACTION ON UPDATE NO ACTION;

ALTER TABLE [dbo].[InvoiceLine] ADD CONSTRAINT [FK_InvoiceLineInvoiceId]
	FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([ProductId]) ON DELETE NO ACTION ON UPDATE NO ACTION;
