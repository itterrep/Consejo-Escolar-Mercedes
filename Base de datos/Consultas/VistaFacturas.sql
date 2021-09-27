CREATE VIEW `consejoescolar`.`vistaFactura` AS
SELECT f.idFactura, f.Fecha, f.Numero, f.IdProveedor, p.RazonSocial, f.Cue, e.Nombre, f.Rubro, f.Monto
FROM factura f
inner join proveedores p on f.idProveedor = p.idProveedor
inner join escuela e on e.cue = f.cue
order by f.Fecha;