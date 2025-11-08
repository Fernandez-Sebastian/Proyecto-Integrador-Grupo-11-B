/* ************************************************
	Creación de la BD y tablas necesarias para 
    el sistema Club Deportivo
************************************************* */
DROP DATABASE IF EXISTS ClubDeportivo;
CREATE DATABASE ClubDeportivo;
USE ClubDeportivo;

-- Crear tabla de roles
DROP TABLE IF EXISTS roles;
CREATE TABLE roles(
RolUsu INT,
NomRol VARCHAR(30),
CONSTRAINT PRIMARY KEY(RolUsu)
);

-- insert de datos de roles
INSERT INTO roles VALUES
(120,'Administrador'),
(121,'Empleado');

-- Crear tabla de usuarios
DROP TABLE IF EXISTS usuario;
CREATE TABLE usuario(
CodUsu INT AUTO_INCREMENT,
NombreUsu VARCHAR (20),
PassUsu VARCHAR (15),
RolUsu INT,
Activo BOOLEAN DEFAULT TRUE,
CONSTRAINT pk_usuario PRIMARY KEY (CodUsu),
CONSTRAINT fk_usuario FOREIGN KEY(RolUsu) REFERENCES roles(RolUsu)
);

-- insert de usuario
INSERT INTO usuario(CodUsu,NombreUsu,PassUsu,RolUsu) VALUES
(1,'emma','123456',120);

-- Crear la tabla Actividad
DROP TABLE IF EXISTS Actividad;
CREATE TABLE Actividad (
    idActividad INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(50) NOT NULL,
    Dia DATE NOT NULL,
    Horario DATETIME NOT NULL,
    Cupo INT NOT NULL,
    ProfesorAsignado VARCHAR(50) NOT NULL,
    PrecioActividad DOUBLE NOT NULL
) ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

-- insert de Actividades
INSERT INTO Actividad (idActividad, Nombre, Dia, Horario, Cupo, ProfesorAsignado, PrecioActividad) VALUES
(1, 'Gym', '2025-11-02', '2025-11-15 23:26:01', 10, 'Juan', 120000);

-- Crear la tabla Socios
DROP TABLE IF EXISTS Socios;
CREATE TABLE Socios (
    idSocio INT(11) AUTO_INCREMENT PRIMARY KEY,
    Dni VARCHAR(15) NOT NULL UNIQUE,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    FechaAlta DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
    AptoMedico ENUM('S', 'N') NOT NULL DEFAULT 'N',
    Habilitado ENUM('S', 'N') NOT NULL DEFAULT 'N'
) ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

-- Crear la tabla NoSocios
DROP TABLE IF EXISTS NoSocios;
CREATE TABLE NoSocios (
    idNoSocio INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    Dni VARCHAR(15) NOT NULL UNIQUE,
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    FechaNacimiento DATE NOT NULL,
    AptoMedico ENUM('S', 'N') NOT NULL,
    idActividad INT(11) DEFAULT NULL  -- REVISAR QUE NO HACE FALTA
) ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

-- se crean índices para la NoSocios
ALTER TABLE nosocios
  ADD KEY idActividad (idActividad);

DROP TABLE IF EXISTS CobroActividad;
CREATE TABLE CobroActividad (
    IdCobro INT AUTO_INCREMENT PRIMARY KEY,
    IdNoSocio INT NOT NULL,
    IdActividad INT NOT NULL,
    Precio DOUBLE NOT NULL,
    Dia DATE NOT NULL,
    Horario TIME NOT NULL,
    MedioDePago VARCHAR(30) NOT NULL,
    FOREIGN KEY (IdNoSocio) REFERENCES NoSocios(IdNoSocio),
    FOREIGN KEY (IdActividad) REFERENCES Actividad(IdActividad)
) ENGINE=InnoDB;

-- se crean índices para cobroactividad
ALTER TABLE cobroactividad
  ADD KEY IdNoSocio (IdNoSocio),
  ADD KEY IdActividad (IdActividad);

-- Crear la tabla Cuota 
DROP TABLE IF EXISTS Cuota;
CREATE TABLE Cuota (
    IdCuota INT(11) NOT NULL AUTO_INCREMENT PRIMARY KEY,
    NumeroCuota INT(11) NOT NULL,
    FechaPago DATE NULL, 
    FechaInicio DATE NOT NULL,
    FechaFin DATE NOT NULL,
    Monto DOUBLE NOT NULL DEFAULT '45000',
    MetodoPago VARCHAR(30) DEFAULT NULL,
    Vigente ENUM ('S', 'N') NOT NULL DEFAULT 'N',
    CantidadCuotaFinanciada ENUM('1','3','6') NOT NULL DEFAULT '1',
    Estado ENUM('Paga', 'Impaga') NOT NULL DEFAULT 'Impaga',
    IdSocio INT NULL,
	FOREIGN KEY (idSocio) REFERENCES Socios(idSocio)
        ON UPDATE CASCADE
        ON DELETE SET NULL    
) ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

-- se crean índices para la tabla cuota
ALTER TABLE cuota
  ADD KEY idSocio (idSocio);

-- Crear la tabla Carnet
DROP TABLE IF EXISTS Carnet;
CREATE TABLE Carnet (
    IdCarnet INT AUTO_INCREMENT PRIMARY KEY,
    FechaEmision DATE NOT NULL,
    FechaVencimiento DATE NOT NULL,
    Numero INT NOT NULL,
    IdSocio INT NULL,
	FOREIGN KEY (idSocio) REFERENCES Socios(idSocio)
        ON UPDATE CASCADE
        ON DELETE SET NULL 
) ENGINE=INNODB DEFAULT CHARSET=utf8mb4;

/* ************************************************
	Creación SP para el ingreso login
************************************************* */
DROP PROCEDURE IF EXISTS IngresoLogin;
DELIMITER //  
CREATE PROCEDURE IngresoLogin(IN Usu VARCHAR(20), IN Pass VARCHAR(15))
BEGIN
-- Se colocan dos parametros de entrada por eso son in
-- uno para el nombre de usuario y el otro para la contraseña
-- observar que la longitud debe ser igual que la longitud del atributo de la tabla

  -- proyecto en la consulta el rol que tiene el usuario que ingresa
  SELECT NomRol
	FROM usuario u INNER JOIN roles r ON u.RolUsu = r.RolUsu
		WHERE NombreUsu = Usu AND PassUsu = Pass -- se compara con los parametros
			AND Activo = 1;  -- el usuario debe estar activo
END 
//
DELIMITER ;

/* ************************************************
	Creación SP para listar socios con 
    cuotas vencidas a la fecha
************************************************* */
DROP PROCEDURE IF EXISTS sp_listar_deudores_por_fecha;
DELIMITER //
CREATE PROCEDURE sp_listar_deudores_por_fecha (IN p_fecha DATE)
BEGIN
	-- Lista de socios con cuota vencida al día p_fecha
    -- El socio debe tener una cuota cuya fechafin sea igual a la fecha ingresada
    -- No debe tener cuotas futuras pagadas, para considerar que está en período de pago
  	SELECT s.Nombre
		,s.Apellido
		,s.Dni
		,COUNT(*) AS CuotasVencidas
		,c.FechaFin        
		,SUM(c.Monto) AS Deuda
	FROM Socios AS s
	INNER JOIN Cuota AS c ON c.idSocio = s.idSocio
	WHERE c.FechaFin = p_fecha -- fecha fin igual a la ingresada
		AND NOT EXISTS (
			SELECT 1
			FROM cuota
			WHERE cuota.idSocio = s.idSocio
				AND cuota.FechaFin > p_fecha
                AND cuota.Estado = 'Paga' -- que no existan cuotas futuras pagadas
			)
	GROUP BY s.Nombre
		,s.Apellido
		,s.Dni
        ,c.FechaFin
	HAVING COUNT(*) > 0
	ORDER BY s.Apellido
		,s.Nombre;
END //
DELIMITER ;

/* ************************************************
	Creación SP para deshabilitar socios 
    vencido el período de pago FechaFin + 5 días
************************************************* */
-- Tabla de logs para monitorear los cambios del día
CREATE TABLE IF NOT EXISTS JobLog (
  IdLog        BIGINT AUTO_INCREMENT PRIMARY KEY,
  job_name     VARCHAR(100) NOT NULL,
  run_at       DATETIME      NOT NULL,
  detail       VARCHAR(500)  NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

DROP PROCEDURE IF EXISTS sp_deshabilitar_socios_periodo_pago_vto;
-- deshabilitamos los socios que el periodo de pago vence hoy
DELIMITER //
CREATE PROCEDURE sp_deshabilitar_socios_periodo_pago_vto(IN p_fecha DATE)
BEGIN
  -- Tomamos la cuota VIGENTE (Vigente = 'S') del socio
  -- Si FechaFin + 5 días == p_fecha y no tengo una prox cuota paga => deshabilitar socio
  -- tomando socios con habilitado = 'S'
  
  IF p_fecha IS NULL THEN
    SET p_fecha = CURDATE();
  END IF;

  -- Actualizar socios alcanzados por la regla
  UPDATE Socios s
  JOIN Cuota c
    ON c.IdSocio = s.idSocio   
  SET s.Habilitado = 'N'
  WHERE s.Habilitado <> 'N'
	AND c.Vigente = 'S'
	AND DATE_ADD(c.FechaFin, INTERVAL 5 DAY) = p_fecha   
	AND NOT EXISTS (SELECT 1 FROM Cuota WHERE idSocio = s.idSocio AND FechaFin > p_fecha AND estado = 'Paga');

  -- Log de los socios deshabilitados
  SET @afectados := ROW_COUNT();
  INSERT INTO JobLog(job_name, run_at, detail)
  VALUES ('sp_deshabilitar_socios_periodo_pago_vto', NOW(),
          CONCAT('Deshabilitados: ', @afectados,
                 ' en fecha=', DATE_FORMAT(p_fecha,'%Y-%m-%d')));
END //
DELIMITER ;

/* ************************************************
	Creación SP para generar la nueva cuota 
    si la fecha fin de la cuota actual coincide 
    con la fecha recibida
************************************************* */
DROP PROCEDURE IF EXISTS sp_generar_nueva_cuota_socio;
DELIMITER //
CREATE PROCEDURE sp_generar_nueva_cuota_socio(IN p_fecha DATE)
BEGIN
  DECLARE v_count INT DEFAULT 0;
  
  IF p_fecha IS NULL THEN
    SET p_fecha = CURDATE();
  END IF;

  START TRANSACTION;

  DROP TEMPORARY TABLE IF EXISTS tmp_socios_cuota;
  
  --  Socios que les creo la cuota:
  --  Tienen una cuota vigente cuyo fechafin es igual a la de hoy
  --  Tienen menos de 5 cuotas impagas en total, para no generarle más deuda
  --  no tiene cuotas futuras pagas 
  CREATE TEMPORARY TABLE tmp_socios_cuota
  ENGINE=Memory
  AS
  SELECT 
      s.idSocio,
      COALESCE(MAX(c_all.NumeroCuota), 0) + 1 AS next_numero
  FROM Socios s
  JOIN Cuota AS c_vig
    ON c_vig.IdSocio = s.idSocio
   AND c_vig.Vigente = 'S'
   AND c_vig.FechaFin = p_fecha  -- nace mismo día de fin
  LEFT JOIN Cuota AS c_all
    ON c_all.IdSocio = s.idSocio
  WHERE (
      SELECT COUNT(*) 
      FROM Cuota AS ci
      WHERE ci.IdSocio = s.idSocio
        AND ci.Estado = 'Impaga'
    ) < 5
    AND NOT EXISTS (SELECT 1 FROM Cuota WHERE idSocio = s.idSocio AND FechaFin > p_fecha AND estado = 'Paga')
  GROUP BY s.idSocio;

  -- Si no hay cuotas a generar no hacemos nada
  SELECT COUNT(*) INTO v_count FROM tmp_socios_cuota;
  
  IF v_count > 0 THEN
	-- Desactivar la cuota vigente actual del socio para que la nueva sea la vigente
	UPDATE Cuota c
	JOIN tmp_socios_cuota t ON t.idSocio = c.IdSocio
	SET c.Vigente = 'N'
	WHERE c.Vigente = 'S'
    AND c.FechaFin = p_fecha;
	
	-- Insertar la nueva cuota para cada socio que cumpla con las condiciones 
	INSERT INTO Cuota
		(NumeroCuota, FechaPago, FechaInicio, FechaFin, Monto, MetodoPago, Vigente, CantidadCuotaFinanciada, Estado, IdSocio)
	SELECT 
		t.next_numero,               -- NumeroCuota
		NULL,                        -- FechaPago (vacía) -- se completa al pagarla
		p_fecha,                     -- FechaInicio
		DATE_ADD(p_fecha, INTERVAL 1 MONTH), -- FechaFin, vence un mes después
		45000,                       -- Monto fijo de la cuota
		NULL,                        -- MetodoPago (vacío) -- se completa al pagarla
		'S',                         -- Vigente
		'1',                         -- CantidadCuotaFinanciada
		'Impaga',                    -- Estado, nace impaga
		t.idSocio                    -- IdSocio
	FROM tmp_socios_cuota t;
  END IF;

  COMMIT;

  DROP TEMPORARY TABLE tmp_socios_cuota;
END //
DELIMITER ;

/* ************************************************
	Creación Trigger para que al registrar un socio 
    se cree automáticamente la primera 
    cuota que se debe pagar
************************************************* */
DROP TRIGGER IF EXISTS trg_nuevo_socio_crear_cuota;
DELIMITER //
CREATE TRIGGER trg_nuevo_socio_crear_cuota
AFTER INSERT ON Socios
FOR EACH ROW
BEGIN
  -- Insertar cuota inicial del nuevo socio
  INSERT INTO Cuota
    (NumeroCuota, FechaPago, FechaInicio, FechaFin, Monto, MetodoPago,
     Vigente, CantidadCuotaFinanciada, Estado, IdSocio)
  VALUES
    (1, -- primera cuota
     NULL, -- FechaPago, nace vacía se genera al pagar
     CURDATE(), -- fecha de hoy
     DATE_ADD(CURDATE(), INTERVAL 1 MONTH), -- FechaFin, vence un mes después
     45000, -- monto fijo 15000
     NULL, -- método pago nace vacío, se genra al pagar
     'S', -- nace vigente
     '1', -- por defecto 1 cuota
     'Impaga', -- nace impaga
     NEW.idSocio); -- id del socio nuevo 
END //
DELIMITER ;

/* ********************************************************
Creación Evento en base de datos para que
se ejecute diariamente en la madrugada
la deshabilitación de socios que se les vence
el período de pago en el día y además se les 
cree la nueva cuota a los socios cuya cuota vence en el día
*********************************************************** */
-- creamos EVENT diario a la 01:00 (hora del server)
-- Requiere tener el scheduler habilitado: SET GLOBAL event_scheduler = ON;
DROP EVENT IF EXISTS ev_actualizar_socios_cuotas_diario;
SET GLOBAL event_scheduler = ON;
DELIMITER //
CREATE EVENT IF NOT EXISTS ev_actualizar_socios_cuotas_diario
ON SCHEDULE
  EVERY 1 DAY
  STARTS TIMESTAMP(CURRENT_DATE + INTERVAL 1 DAY, '01:00:00') -- todos los días a la 01:00
DO
BEGIN
  CALL sp_deshabilitar_socios_periodo_pago_vto(CURDATE()); -- vencido periodo de pago
  CALL sp_generar_nueva_cuota_socio(CURDATE()); -- fecha fin de la cuota
END //
DELIMITER ;

