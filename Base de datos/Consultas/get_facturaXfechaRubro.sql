DELIMITER $$

DROP PROCEDURE IF EXISTS `consejoescolar`.`get_facturaxfechaRubro` $$
CREATE PROCEDURE `consejoescolar`.`get_facturaxfechaRubro` (desde date,hasta date,Rubro varchar(45))
BEGIN

SELECT f.idFactura, f.Fecha, f.Numero, f.IdProveedor, p.RazonSocial, f.Cue, e.Nombre, f.Rubro, f.Monto
FROM factura f
inner join proveedores p on f.idProveedor = p.idProveedor
inner join escuela e on e.cue = f.cue
where f.fecha >= desde and f.fecha <= hasta and f.rubro = Rubro
order by f.Fecha;

END $$

DELIMITER ;