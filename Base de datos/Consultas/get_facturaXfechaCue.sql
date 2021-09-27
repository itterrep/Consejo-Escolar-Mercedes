DELIMITER $$

DROP PROCEDURE IF EXISTS `consejoescolar`.`get_facturaxfechaCue` $$
CREATE PROCEDURE `consejoescolar`.`get_facturaxfechaCue` (desde date,hasta date,cue varchar(9))
BEGIN

SELECT f.idFactura, f.Fecha, f.Numero, f.IdProveedor, p.RazonSocial, f.Cue, e.Nombre, f.Rubro, f.Monto
FROM factura f
inner join proveedores p on f.idProveedor = p.idProveedor
inner join escuela e on e.cue = f.cue
where f.fecha >= desde and f.fecha <= hasta and f.cue = cue
order by f.Fecha;

END $$

DELIMITER ;