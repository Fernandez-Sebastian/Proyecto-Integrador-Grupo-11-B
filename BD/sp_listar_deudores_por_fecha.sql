DELIMITER //
DROP PROCEDURE IF EXISTS sp_listar_deudores_por_fecha;
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
//
DELIMITER ;
