-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 05-11-2025 a las 02:36:25
-- Versión del servidor: 10.1.40-MariaDB
-- Versión de PHP: 7.2.18

DROP DATABASE IF EXISTS `clubdeportivo`;
CREATE DATABASE `clubdeportivo` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci */;
USE `clubdeportivo`;

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;



DELIMITER $$
--
-- Procedimientos
--
DROP PROCEDURE IF EXISTS `IngresoLogin`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `IngresoLogin` (IN `Usu` VARCHAR(20), IN `Pass` VARCHAR(15))  BEGIN
  /* proyecto en la consulta el rol que tiene el usuario que ingresa */
  
  SELECT NomRol
	FROM usuario u INNER JOIN roles r ON u.RolUsu = r.RolUsu
		WHERE NombreUsu = Usu AND PassUsu = Pass /* se compara con los parametros */
			AND Activo = 1; /* el usuario debe estar activo */


END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `actividad`
--

DROP TABLE IF EXISTS `actividad`;
CREATE TABLE `actividad` (
  `idActividad` INT(11) NOT NULL,
  `Nombre` VARCHAR(50) NOT NULL,
  `Dia` DATE NOT NULL,
  `Horario` DATETIME NOT NULL,
  `Cupo` INT(11) NOT NULL,
  `ProfesorAsignado` VARCHAR(50) NOT NULL,
  `PrecioActividad` DOUBLE NOT NULL
) ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `actividad`
--

INSERT INTO `actividad` (`idActividad`, `Nombre`, `Dia`, `Horario`, `Cupo`, `ProfesorAsignado`, `PrecioActividad`) VALUES
(1, 'Gym', '2025-11-02', '2025-11-15 23:26:01', 10, 'Juan', 120000);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cobroactividad`
--

DROP TABLE IF EXISTS `cobroactividad`;
CREATE TABLE `cobroactividad` (
  `IdCobro` INT(11) NOT NULL,
  `IdNoSocio` INT(11) NOT NULL,
  `IdActividad` INT(11) NOT NULL,
  `Precio` DOUBLE NOT NULL,
  `Dia` DATE NOT NULL,
  `Horario` TIME NOT NULL,
  `MedioDePago` VARCHAR(30) NOT NULL
) ENGINE=INNODB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cobroactividad`
--

INSERT INTO `cobroactividad` (`IdCobro`, `IdNoSocio`, `IdActividad`, `Precio`, `Dia`, `Horario`, `MedioDePago`) VALUES
(1, 1, 1, 120000, '2025-11-02', '23:29:56', 'Efectivo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuota`
--
DROP TABLE IF EXISTS `cuota`;

CREATE TABLE `cuota` (
  `idCuota` INT(11) NOT NULL AUTO_INCREMENT,
  `idSocio` INT(11) DEFAULT NULL,
  `NumeroCuota` INT(11) NOT NULL,
  `FechaPago` DATE NOT NULL,
  `FechaInicio` DATE NOT NULL,
  `FechaFin` DATE NOT NULL,
  `Monto` DOUBLE NOT NULL DEFAULT '45000',
  `MetodoPago` VARCHAR(30) DEFAULT NULL,
  `Vigente` ENUM('S','N') NOT NULL DEFAULT 'N',
  `CantidadCuotaFinanciada` ENUM('1','3','6') NOT NULL DEFAULT '1',
  `Estado` ENUM('Paga','Impaga') NOT NULL DEFAULT 'Impaga',
  PRIMARY KEY (`idCuota`)
) ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

-- Volcado de datos para la tabla `cuota`

INSERT INTO `cuota` (`idSocio`, `NumeroCuota`, `FechaPago`, `FechaInicio`, `FechaFin`, `Monto`, `MetodoPago`, `Vigente`, `CantidadCuotaFinanciada`, `Estado`) VALUES
(1, 3, '2025-11-04', '2025-01-01', '2025-02-01', 45000, 'Efectivo', 'N', '1', 'Paga'),
(1, 4, '2025-11-04', '2025-02-01', '2025-03-01', 45000, 'Tarjeta', 'N', '6', 'Impaga'),
(1, 5, '2025-11-04', '2025-03-01', '2025-04-01', 45000, 'Efectivo', 'N', '1', 'Impaga'),
(1, 6, '2025-11-04', '2025-04-01', '2025-05-01', 45000, 'Efectivo', 'N', '1', 'Paga'),
(1, 7, '2025-11-04', '2025-05-01', '2025-06-01', 45000, 'Efectivo', 'N', '1', 'Impaga'),
(1, 8, '2025-11-04', '2025-06-01', '2025-07-01', 45000, 'Tarjeta', 'N', '3', 'Impaga'),
(1, 9, '2025-11-04', '2025-07-01', '2025-08-01', 45000, 'Efectivo', 'N', '1', 'Impaga'),
(1, 10, '2025-11-04', '2025-08-01', '2025-09-01', 45000, 'Efectivo', 'N', '1', 'Impaga'),
(1, 11, '2025-11-04', '2025-09-01', '2025-10-01', 45000, 'Efectivo', 'N', '1', 'Impaga'),
(1, 12, '2025-11-04', '2025-10-10', '2025-11-10', 45000, 'Transferencia', 'N', '1', 'Paga'),
(1, 13, '2025-11-04', '2025-11-10', '2025-12-10', 45000, 'Tarjeta', 'S', '3', 'Impaga'),
(2, 1, '0000-00-00', '2025-11-01', '2025-12-01', 45000, '', 'N', '1', 'Impaga'),
(2, 2, '0000-00-00', '2025-12-01', '2026-01-01', 45000, '', 'S', '1', 'Impaga'),
(3, 1, '0000-00-00', '2025-11-01', '2025-12-01', 45000, '', 'N', '1', 'Impaga'),
(3, 2, '0000-00-00', '2025-12-01', '2026-01-01', 45000, '', 'S', '1', 'Impaga'),
(4, 1, '0000-00-00', '2025-11-01', '2025-12-01', 45000, '', 'N', '1', 'Impaga'),
(4, 2, '0000-00-00', '2025-12-01', '2026-01-01', 45000, '', 'S', '1', 'Impaga'),
(5, 1, '0000-00-00', '2025-11-01', '2025-12-01', 45000, '', 'N', '1', 'Impaga'),
(5, 2, '0000-00-00', '2025-12-01', '2026-01-01', 45000, '', 'S', '1', 'Impaga'),
(6, 1, '0000-00-00', '2025-11-01', '2025-12-01', 45000, '', 'N', '1', 'Impaga'),
(6, 2, '0000-00-00', '2025-12-01', '2026-01-01', 45000, '', 'S', '1', 'Impaga'),
(7, 1, '0000-00-00', '2025-11-01', '2025-12-01', 45000, '', 'N', '1', 'Impaga'),
(7, 2, '0000-00-00', '2025-12-01', '2026-01-01', 45000, '', 'S', '1', 'Impaga'),
(8, 1, '0000-00-00', '2025-11-01', '2025-12-01', 45000, '', 'N', '1', 'Impaga'),
(8, 2, '0000-00-00', '2025-12-01', '2026-01-01', 45000, '', 'S', '1', 'Impaga'),
(9, 1, '0000-00-00', '2025-11-01', '2025-12-01', 45000, '', 'N', '1', 'Impaga'),
(9, 2, '0000-00-00', '2025-12-01', '2026-01-01', 45000, '', 'S', '1', 'Impaga'),
(10, 1, '0000-00-00', '2025-11-01', '2025-12-01', 45000, '', 'N', '1', 'Impaga'),
(10, 2, '0000-00-00', '2025-12-01', '2026-01-01', 45000, '', 'S', '1', 'Impaga');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nosocios`
--

DROP TABLE IF EXISTS `nosocios`;
CREATE TABLE `nosocios` (
  `idNoSocio` INT(11) NOT NULL,
  `Dni` VARCHAR(15) NOT NULL,
  `Nombre` VARCHAR(50) NOT NULL,
  `Apellido` VARCHAR(50) NOT NULL,
  `FechaNacimiento` DATE NOT NULL,
  `AptoMedico` ENUM('S','N') NOT NULL,
  `idActividad` INT(11) DEFAULT NULL
) ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `nosocios`
--

INSERT INTO `nosocios` (`idNoSocio`, `Dni`, `Nombre`, `Apellido`, `FechaNacimiento`, `AptoMedico`, `idActividad`) VALUES
(1, '123456', 'Seba', 'Fer', '1990-03-11', 'S', NULL);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `roles`
--

DROP TABLE IF EXISTS `roles`;
CREATE TABLE `roles` (
  `RolUsu` INT(11) NOT NULL,
  `NomRol` VARCHAR(30) DEFAULT NULL
) ENGINE=INNODB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `roles`
--

INSERT INTO `roles` (`RolUsu`, `NomRol`) VALUES
(120, 'Administrador'),
(121, 'Empleado');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `socios`
--

DROP TABLE IF EXISTS `socios`;
CREATE TABLE `socios` (
  `idSocio` INT(11) NOT NULL,
  `Dni` VARCHAR(15) NOT NULL,
  `Nombre` VARCHAR(50) NOT NULL,
  `Apellido` VARCHAR(50) NOT NULL,
  `FechaNacimiento` DATE NOT NULL,
  `AptoMedico` ENUM('S','N') NOT NULL DEFAULT 'N',
  `Habilitado` ENUM('S','N') NOT NULL DEFAULT 'N',
  `FechaPagoCuota` DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `socios`
--

INSERT INTO `socios` (`idSocio`, `Dni`, `Nombre`, `Apellido`, `FechaNacimiento`, `AptoMedico`, `Habilitado`, `FechaPagoCuota`) VALUES
(1, '123456', 'Seba', 'Fernandez', '1990-03-11', 'S', 'N', '2025-10-28 00:24:38'),
(2, '123123', 'sdasdasd', 'dasdasd', '2000-02-09', 'S', 'N', '2025-10-28 00:24:38'),
(3, '1324477', 'asdasdas', 'asdasddddddd', '2004-06-17', 'S', 'N', '2025-10-28 00:24:38'),
(4, '2525255', 'iuiuiasudi', 'asdjiujddjajd', '2019-06-06', 'S', 'N', '2025-10-28 00:24:38'),
(5, '34741667', 'Sebas', 'Fernandez', '1990-03-11', 'S', 'N', '2025-10-28 00:24:38'),
(6, '34741686', 'alan', 'R', '2019-07-05', 'S', 'N', '2025-10-28 00:24:38'),
(7, '123123444444', 'dasdasdasdas', 'aaaa', '1995-07-14', 'S', 'N', '2025-10-28 00:24:38'),
(8, '13244772', 'Seba', 'asdasd', '2005-07-15', 'S', 'N', '2025-10-28 00:24:38'),
(9, '23232', 'asdasd', 'asdas', '2004-06-16', 'S', 'N', '2025-10-28 00:24:38'),
(10, '2323244343434', 'dasdasdas', 'asdasdasd', '2020-01-08', 'S', 'N', '2025-10-28 00:24:38');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuario`
--

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE `usuario` (
  `CodUsu` INT(11) NOT NULL,
  `NombreUsu` VARCHAR(20) DEFAULT NULL,
  `PassUsu` VARCHAR(15) DEFAULT NULL,
  `RolUsu` INT(11) DEFAULT NULL,
  `Activo` TINYINT(1) DEFAULT '1'
) ENGINE=INNODB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuario`
--

INSERT INTO `usuario` (`CodUsu`, `NombreUsu`, `PassUsu`, `RolUsu`, `Activo`) VALUES
(1, 'emma', '123456', 120, 1);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `actividad`
--
ALTER TABLE `actividad`
  ADD PRIMARY KEY (`idActividad`);

--
-- Indices de la tabla `cobroactividad`
--
ALTER TABLE `cobroactividad`
  ADD PRIMARY KEY (`IdCobro`),
  ADD KEY `IdNoSocio` (`IdNoSocio`),
  ADD KEY `IdActividad` (`IdActividad`);

--
-- Indices de la tabla `cuota`
--
ALTER TABLE `cuota`
  ADD KEY `idSocio` (`idSocio`);

--
-- Indices de la tabla `nosocios`
--
ALTER TABLE `nosocios`
  ADD PRIMARY KEY (`idNoSocio`),
  ADD UNIQUE KEY `Dni` (`Dni`),
  ADD KEY `idActividad` (`idActividad`);

--
-- Indices de la tabla `roles`
--
ALTER TABLE `roles`
  ADD PRIMARY KEY (`RolUsu`);

--
-- Indices de la tabla `socios`
--
ALTER TABLE `socios`
  ADD PRIMARY KEY (`idSocio`),
  ADD UNIQUE KEY `Dni` (`Dni`);

--
-- Indices de la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD PRIMARY KEY (`CodUsu`),
  ADD KEY `fk_usuario` (`RolUsu`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `actividad`
--
ALTER TABLE `actividad`
  MODIFY `idActividad` INT(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `cobroactividad`
--
ALTER TABLE `cobroactividad`
  MODIFY `IdCobro` INT(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `cuota`
--
ALTER TABLE `cuota`
  MODIFY `idCuota` INT(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=77;

--
-- AUTO_INCREMENT de la tabla `nosocios`
--
ALTER TABLE `nosocios`
  MODIFY `idNoSocio` INT(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de la tabla `socios`
--
ALTER TABLE `socios`
  MODIFY `idSocio` INT(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT de la tabla `usuario`
--
ALTER TABLE `usuario`
  MODIFY `CodUsu` INT(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `cobroactividad`
--
ALTER TABLE `cobroactividad`
  ADD CONSTRAINT `cobroactividad_ibfk_1` FOREIGN KEY (`IdNoSocio`) REFERENCES `nosocios` (`idNoSocio`),
  ADD CONSTRAINT `cobroactividad_ibfk_2` FOREIGN KEY (`IdActividad`) REFERENCES `actividad` (`idActividad`);

--
-- Filtros para la tabla `cuota`
--
ALTER TABLE `cuota`
  ADD CONSTRAINT `cuota_ibfk_1` FOREIGN KEY (`idSocio`) REFERENCES `socios` (`idSocio`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Filtros para la tabla `nosocios`
--
ALTER TABLE `nosocios`
  ADD CONSTRAINT `nosocios_ibfk_1` FOREIGN KEY (`idActividad`) REFERENCES `actividad` (`idActividad`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Filtros para la tabla `usuario`
--
ALTER TABLE `usuario`
  ADD CONSTRAINT `fk_usuario` FOREIGN KEY (`RolUsu`) REFERENCES `roles` (`RolUsu`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
