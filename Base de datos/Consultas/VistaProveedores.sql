CREATE VIEW `consejoescolar`.`VistaProveedores` AS
SELECT p.RazonSocial, p.Domicilio, p.Localidad, p.TelFijo, p.TelCelular, p.CUIT, p.Email, p.Comentarios, pr.Rubro
 FROM proveedores p
left Join proveedorrubro pr on p.idproveedor = pr.idproveedor
ORDER BY PR.Rubro;