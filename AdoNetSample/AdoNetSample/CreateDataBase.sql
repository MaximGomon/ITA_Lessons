USE [master]
GO

IF DB_ID('Organization') IS NOT NULL
BEGIN
  DROP DATABASE [Organization]
END
GO

CREATE DATABASE [Organization]
GO

USE [Organization]
GO

CREATE TABLE dbo.Employees
(
  ID        INT,
  Name      NVARCHAR(MAX),
  BirthDate DATETIME2(7),
  Email     NVARCHAR(MAX),
  Salary    NVARCHAR(MAX),
  CONSTRAINT PK_Employees_ID PRIMARY KEY (ID)
)
GO

INSERT INTO dbo.Employees
(
  ID, Name, BirthDate, Email, Salary
)
VALUES
  (1, N'Max', '1994-08-20', N'mymail@mail.com', N'2000')