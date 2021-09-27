CREATE VIEW `consejoescolar`.`VistaSecretarioEscuelaTurno` AS
SELECT e.idescuelapersonal as Codigo, s.IDSecretario as DNI, s.Nombre, s.Apellido, E.CUE, ES.Nombre as NombreEscuela, E.Turno,e.SituacionRevista
FROM Secretario s
left join escuelapersonal e on s.idsecretario = e.IdDirectivo
inner join escuela es on es.cue = e.cue
WHERE E.TipoDirectivo = 'Secretario';