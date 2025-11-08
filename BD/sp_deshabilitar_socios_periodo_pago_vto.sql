-- Tabla de logs para monitorear los cambios del día
CREATE TABLE IF NOT EXISTS JobLog (
  IdLog        BIGINT AUTO_INCREMENT PRIMARY KEY,
  job_name     VARCHAR(100) NOT NULL,
  run_at       DATETIME      NOT NULL,
  detail       VARCHAR(500)  NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

DROP PROCEDURE IF EXISTS sp_deshabilitar_socios_periodo_pago_vto;
-- deshabilitamos los socios que el periodo de pago vence hoy
DELIMITER $$
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

  -- Log
  SET @afectados := ROW_COUNT();
  INSERT INTO JobLog(job_name, run_at, detail)
  VALUES ('sp_deshabilitar_socios_periodo_pago_vto', NOW(),
          CONCAT('Deshabilitados: ', @afectados,
                 ' en fecha=', DATE_FORMAT(p_fecha,'%Y-%m-%d')));
END $$
DELIMITER ;
