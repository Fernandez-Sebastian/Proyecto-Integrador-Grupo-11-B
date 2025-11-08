DELIMITER //
DROP PROCEDURE IF EXISTS sp_listar_deudores_por_fecha;
CREATE PROCEDURE sp_listar_deudores_por_fecha (IN p_fecha DATE)
BEGIN
	/* Lista de socios con cuota vencida al día p_fecha */
	SELECT s.Nombre
		,s.Apellido
		,s.Dni
		,COUNT(*) AS CuotasVencidas
		,c.FechaFin        
		,SUM(c.Monto) AS Deuda
	FROM Socios AS s
	INNER JOIN Cuota AS c ON c.idSocio = s.idSocio
	WHERE c.FechaFin = p_fecha
		AND NOT EXISTS (
			SELECT 1
			FROM cuota
			WHERE cuota.idSocio = s.idSocio
				AND cuota.Estado = 'Impaga'
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
