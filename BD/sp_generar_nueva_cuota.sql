DROP PROCEDURE IF EXISTS sp_generar_nueva_cuota_socio;
DELIMITER $$

CREATE PROCEDURE sp_generar_nueva_cuota_socio(IN p_fecha DATE)
BEGIN
  DECLARE v_count INT DEFAULT 0;
  
  IF p_fecha IS NULL THEN
    SET p_fecha = CURDATE();
  END IF;

  START TRANSACTION;

  DROP TEMPORARY TABLE IF EXISTS tmp_socios_cuota;
  
  -- Socios que les creo la cuota:
  --  Tienen una cuota vigente cuyo fechafin es igual a la de hoy
  --  Tienen menos de 5 cuotas impagas en total, para no generarle más deuda
  -- no tiene cuotas futuras pagas 
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
  SELECT COUNT(*) INTO v_count FROM tmp_socios_elegibles;
  
  IF v_count > 0 THEN
	-- Desactivar la cuota vigente actual del socio para que la nueva sea la vigente
	UPDATE Cuota c
	JOIN tmp_socios_elegibles t ON t.idSocio = c.IdSocio
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
	FROM tmp_socios_elegibles t;
  END IF;

  COMMIT;

  DROP TEMPORARY TABLE tmp_socios_elegibles;
END $$

DELIMITER ;
