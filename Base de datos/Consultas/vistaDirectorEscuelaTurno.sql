CREATE VIEW `consejoescolar`.`VistaDirectorEscuelaTurno` AS
SELECT e.idescuelapersonal as Codigo, D.IDDirector as DNI, D.Nombre,D.Apellido,E.CUE, ES.Nombre as NombreEscuela,E.Turno, e.SituacionRevista
FROM director d
left join escuelapersonal e on d.iddirector = e.IdDirectivo
inner join escuela es on es.cue = e.cue
WHERE E.TipoDirectivo = 'Director';