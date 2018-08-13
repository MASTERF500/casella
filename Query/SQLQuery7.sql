select distinct 
es.numero,
es.nombre,
es.latitud,
es.longitud,
es.estadoid
from estaciones es, estado1 edo1, estado8 edo2
where es.numero=edo1.numero and edo1.fecha > '25/05/2018' and es.activa=1
union
select distinct 
es.numero,
es.nombre,
es.latitud,
es.longitud,
es.estadoid
from estaciones es, estado8 edo1
where es.numero=edo1.numero and edo1.fecha > '25/05/2018' and es.activa=1



select * from estado1 where fecha > '25/05/2018' and numero=2
select count(*) from estaciones where activa!=1 

create procedure desfaseDatos()
@fecha datetime
as
begin
select distinct 
es.numero,
es.nombre,
es.latitud,
es.longitud,
es.estadoid
from estaciones es, estado1 edo1, estado8 edo2
where es.numero=edo1.numero and edo1.fecha > @fecha and es.activa=1
union
select distinct 
es.numero,
es.nombre,
es.latitud,
es.longitud,
es.estadoid
from estaciones es, estado8 edo1
where es.numero=edo1.numero and edo1.fecha  @fecha and es.activa=1
end

/*Toma el ultimo dato desfasado por estacion*/
select top(1) fecha from estado1 where fecha != getdate() and numero=2 
order by fecha desc



select
datediff (hh,max(fecha),getdate()) as horasdiff,
max(fecha), getdate() as fechaActual 
from estado1 edo1,estaciones es where es.numero=edo1.numero


select distinct datediff (hh,(),getdate()) as horasdiff, es.nombre from estaciones es, estado1 edo1
where es.numero=edo1.numero and es.activa!=1 and es.fecha>(select max(fecha) from estado1, where  )



select
es.numero,
es.nombre,
es.latitud,
es.longitud,
es.estadoid,
datediff (hh,max(edo1.fecha),getdate()) as horasdiff,
getdate() as fechaActual 
from estaciones es, estado1 edo1
where es.numero=edo1.numero and es.activa=1
having max(edo1.fecha)



datediff (mi,max(edo1.fecha),getdate()) as mindiff,


select distinct es.numero as num, max(edo1.fecha)
from estaciones es, estado1 edo1 
where es.numero=edo1.numero


select distinct
datediff (hh,max(fecha),getdate()) as horasdiff, es.numero as num, es.estadoid as x
from estado1 edo1,estaciones es where es.numero=edo1.numero
group by x

/*Desfase de horas para una estacion*/
select datediff (hh,max(fecha),getdate()) as horasdiff from estado1 where numero=25420
/*Desfase de horas para las estaciones de un estado*/
select 
S.numero,
S.nombre,
S.latitud,
S.longitud,
S.estadoid,
datediff (hh,max(T.fecha),getdate()) as h
from estado1 T,estaciones S
where S.numero=T.numero and S.activa=1
group by S.numero,S.nombre,S.latitud,S.longitud,S.estadoid
union

select 
S.numero,
S.nombre,
S.latitud,
S.longitud,
S.estadoid,
datediff (hh,max(T.fecha),getdate()) as h
from estado8 T,estaciones S
where S.numero=T.numero and S.activa=1  and T.fecha >= '28/05/2018'
group by S.numero,s.nombre,S.latitud,S.longitud,S.estadoid
order by S.numero

select getdate()

