DELIMITER $$

DROP PROCEDURE IF EXISTS `consejoescolar`.`Get_EscuelasTipo` $$
CREATE PROCEDURE `consejoescolar`.`Get_EscuelasTipo` (tipo varchar(20))
BEGIN

SELECT e.Cue, e.Tipo, e.Nombre, e.Direccion, e.Tel1, e.Tel2, e.Email
FROM consejoescolar.escuela e
where e.tipo = tipo;

END $$

DELIMITER ;