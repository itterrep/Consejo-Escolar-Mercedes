DELIMITER $$

DROP PROCEDURE IF EXISTS `consejoescolar`.`get_facturaxfechaAll` $$
CREATE PROCEDURE `consejoescolar`.`get_facturaxfechaAll` (desde date,hasta date)
BEGIN

SELECT f.idFactura, f.Fecha, f.Numero, f.IdProveedor, p.RazonSocial, f.Cue, e.Nombre, f.Rubro, f.Monto
FROM factura f
inner join proveedores p on f.idProveedor = p.idProveedor
inner join escuela e on e.cue = f.cue
where f.fecha >= desde and f.fecha <= hasta
order by f.Fecha;

END $$

DELIMITER ;