-- creamos EVENT diario a la 01:00 (hora del server)
-- Requiere tener el scheduler habilitado: SET GLOBAL event_scheduler = ON;
DROP EVENT IF EXISTS ev_actualizar_socios_cuotas_diario;
SET GLOBAL event_scheduler = ON;

DELIMITER $$
CREATE EVENT IF NOT EXISTS ev_actualizar_socios_cuotas_diario
ON SCHEDULE
  EVERY 1 DAY
  STARTS (TIMESTAMP(CURDATE() + INTERVAL 1 DAY) + INTERVAL 1 HOUR)  -- todos los días a la 01:00
DO
BEGIN
  CALL sp_deshabilitar_socios_periodo_pago_vto(CURDATE()); -- vencido periodo de pago
  CALL sp_generar_nueva_cuota_socio(CURDATE()); -- fecha fin de la cuota
END $$
DELIMITER ;
