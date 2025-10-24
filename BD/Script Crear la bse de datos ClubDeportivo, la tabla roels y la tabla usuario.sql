﻿DROP DATABASE IF EXISTS ClubDeportivo;
CREATE DATABASE ClubDeportivo;
USE ClubDeportivo;

CREATE TABLE roles(
RolUsu INT,
NomRol VARCHAR(30),
CONSTRAINT PRIMARY KEY(RolUsu)
);

INSERT INTO roles VALUES
(120,'Administrador'),
(121,'Empleado');

CREATE TABLE usuario(
CodUsu INT AUTO_INCREMENT,
NombreUsu VARCHAR (20),
PassUsu VARCHAR (15),
RolUsu INT,
Activo BOOLEAN DEFAULT TRUE,
CONSTRAINT pk_usuario PRIMARY KEY (CodUsu),
CONSTRAINT fk_usuario FOREIGN KEY(RolUsu) REFERENCES roles(RolUsu)
);

-- Crear la tabla Actividad
CREATE TABLE Actividad (
    idActividad INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Dia DATE NOT NULL,
    Horario DATETIME NOT NULL,
    Cupo INT NOT NULL,
    ProfesorAsignado VARCHAR(50) NOT NULL,
    PrecioActividad DOUBLE NOT NULL
) ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

-- Crear la tabla Socios
CREATE TABLE Socios (
    idSocio INT AUTO_INCREMENT PRIMARY KEY,
    Dni VARCHAR(15) NOT NULL UNIQUE,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    AptoMedico ENUM('S', 'N') NOT NULL DEFAULT 'N',
    Habilitado ENUM('S', 'N') NOT NULL DEFAULT 'N'
) ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

-- Crear la tabla NoSocios
CREATE TABLE NoSocios (
    idNoSocio INT AUTO_INCREMENT PRIMARY KEY,
    Dni VARCHAR(15) NOT NULL UNIQUE,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    AptoMedico ENUM('S', 'N') NOT NULL,
    idActividad INT,  -- 🔗 Clave foránea
    FOREIGN KEY (idActividad) REFERENCES Actividad(idActividad)
        ON UPDATE CASCADE
        ON DELETE SET NULL
) ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

INSERT INTO usuario(CodUsu,NombreUsu,PassUsu,RolUsu) VALUES
(1,'emma','123456',120);