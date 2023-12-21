CREATE TABLE [dbo].[ClientTable]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] NCHAR(150) NOT NULL, 
    [email] NCHAR(150) NOT NULL, 
    [phone] NCHAR(11) NOT NULL, 
    [registerDate] DATE NOT NULL, 
    [blockedClient] TINYINT NULL, 
    [clientType] BIT NOT NULL, 
    [cnpj] NCHAR(14) NULL, 
    [cpf] NCHAR(11) NULL, 
    [inscricaoEstadual] NCHAR(12) NULL, 
    [cpfGender] BIT NULL, 
    [cpfBirthDate] DATE NULL, 
    [clientPassword] NCHAR(10) NOT NULL
)
