
/* se cambia el delimitador de linea para poder almacenar en
el sistema gestor el código del procedimiento
Se puede utilizar cualquier caracater 
*************************************************   */

DELIMITER //  
CREATE PROCEDURE IngresoLogin(IN Usu VARCHAR(20),IN Pass VARCHAR(15))

/* =============================================================================
Se colocan dos parametros de entrada por eso son in
uno para el nombre de usuario y el otro para la contraseña
observar que la longitud debe ser igual que la longitud del atributo de la tabla
===================================================================================  */
BEGIN
  /* proyecto en la consulta el rol que tiene el usuario que ingresa */
  
  SELECT NomRol
	FROM usuario u INNER JOIN roles r ON u.RolUsu = r.RolUsu
		WHERE NombreUsu = Usu AND PassUsu = Pass /* se compara con los parametros */
			AND Activo = 1; /* el usuario debe estar activo */


END 
//

/* ==========================
si queremos probar el procedure se usa call
====================================================== */

CALL IngresoLogin('dato1', 'dato2')//

/* ===============================
si los datos de los parametros existen la consulta arroja 1 FILA
si los datos de los parametros NO EXISTEN la consulta arroja 0 FILAS
============================================================================= */