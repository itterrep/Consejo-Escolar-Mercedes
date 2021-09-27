CREATE VIEW `consejoescolar`.`VistaAuxiliarEscuelaTurno` AS
SELECT e.idEscuelaPersonal as Codigo, a.IDAuxiliar as DNI, a.Nombre, a.Apellido, E.CUE, ES.Nombre as NombreEscuela, E.Turno,e.SituacionRevista
FROM Auxiliar a
left join escuelapersonal e on a.idAuxiliar = e.IdDirectivo
inner join escuela es on es.cue = e.cue
WHERE E.TipoDirectivo = 'Auxiliar';