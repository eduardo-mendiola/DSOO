use instituto;
select * from edicion;

select c.nombre, e.fecha, concat(d.NombreD, ' ', d.ApellidoD) as Docente, c.precio 
from curso c 
inner join edicion e on c.NCurso = e.NCurso 
inner join docente d on e.docente = d.NDocente 
where e.fecha > curdate() 
order by c.nombre;

select * from curso;
select * from edicion;
select * from docente;
SHOW COLUMNS FROM edicion;
select e.fecha from edicion e;

select * from postulante;
select * from inscripcion;
select idinscri, nombre, concat(nombrep, ' ', apellidop), precio,e.fecha 
from inscripcion i 
inner join edicion e on i.idEdicion = e.idEdicion
inner join curso c on c.ncurso = e.ncurso inner 
join alumno a on a.legajo = i.legajo
inner join postulante p on p.NPostu = a.Npostu 
where idinscri = 1421;


