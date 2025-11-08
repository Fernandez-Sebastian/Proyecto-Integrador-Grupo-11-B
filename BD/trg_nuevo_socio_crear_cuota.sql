DELIMITER $$

DROP TRIGGER IF EXISTS trg_nuevo_socio_crear_cuota $$
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
END $$
DELIMITER ;
