CREATE TABLE [dbo].[Table]
(
	[name] INT NOT NULL , 
    [email] NCHAR(10) NOT NULL, 
    [phone] NCHAR(10) NOT NULL, 
    [registerDate] NCHAR(10) NOT NULL, 
    [blockedClient] NCHAR(10) NULL, 
    [personType] NCHAR(10) NOT NULL, 
    [cpfOrCnpj] NCHAR(10) NOT NULL, 
	[inscricaoEstadual] NCHAR(10) NULL,
    [gender] NCHAR(10) NULL, 
    [birthDate] NCHAR(10) NULL, 
    [password] NCHAR(10) NOT NULL, 
)
