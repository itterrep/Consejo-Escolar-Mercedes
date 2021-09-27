DELIMITER $$

DROP PROCEDURE IF EXISTS `consejoescolar`.`get_facturaxfechaProveedor` $$
CREATE PROCEDURE `consejoescolar`.`get_facturaxfechaProveedor` (desde date,hasta date,Proveedor varchar(45))
BEGIN

SELECT f.idFactura, f.Fecha, f.Numero, f.IdProveedor, p.RazonSocial, f.Cue, e.Nombre, f.Rubro, f.Monto
FROM factura f
inner join proveedores p on f.idProveedor = p.idProveedor
inner join escuela e on e.cue = f.cue
where f.fecha >= desde and f.fecha <= hasta and p.RazonSocial = Proveedor
order by f.Fecha;

END $$

DELIMITER ;