-- CREATE DATABASE SNAKE
USE SNAKE
GO

CREATE TABLE Jugadores(
    IdIdentity INT IDENTITY(1,1),
    IdJugador INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    FechaRegistro DATETIME DEFAULT GETDATE()
);
GO

CREATE TABLE Partidas(
    IdIdentity INT IDENTITY(1,1),
    IdPartidas INT PRIMARY KEY,
    IdJugador INT NOT NULL,
    Puntaje INT NOT NULL,
    DuracionSegundos INT NOT NULL,
    Fecha DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Partidas_Jugadores FOREIGN KEY (IdJugador)
        REFERENCES Jugadores(IdJugador)
);
GO

CREATE TABLE Configuraciones(
    IdIdentity INT IDENTITY(1,1),
    IdConfiguraciones INT PRIMARY KEY,
    IdJugador INT NOT NULL,
    Ancho INT NOT NULL,
    Alto INT NOT NULL,
    Velocidad INT NOT NULL,
    FechaModificacion DATETIME DEFAULT GETDATE(),
    CONSTRAINT FK_Configuraciones_Jugadores FOREIGN KEY (IdJugador)
        REFERENCES Jugadores(IdJugador)
);
GO
