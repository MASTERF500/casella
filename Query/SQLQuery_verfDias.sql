select top(1) es.id,es.nombre,max(est.fecha) as fecha from caborca_estaciones es, caborca_estacion_1 est where es.id=1
group by es.id,es.nombre,est.fecha
union
select top(1) es.id,es.nombre,max(est.fecha) as fecha from caborca_estaciones es, caborca_estacion_2 est where es.id=2
group by es.id,es.nombre,est.fecha
union
select top(1) es.id,es.nombre,max(est.fecha) as fecha from caborca_estaciones es, caborca_estacion_3 est where es.id=3
group by es.id,es.nombre,est.fecha
union
select top(1) es.id,es.nombre,max(est.fecha) as fecha from caborca_estaciones es, caborca_estacion_4 est where es.id=4
group by es.id,es.nombre,est.fecha
union
select top(1) es.id,es.nombre,max(est.fecha) as fecha from caborca_estaciones es, caborca_estacion_5 est where es.id=5
group by es.id,es.nombre,est.fecha

select * from caborca_estaciones
select max(fecha) as est1 , datediff(day,max(fecha),Getdate()) as faltan from caborca_estacion_1
select max(fecha) as est2 , datediff(day,max(fecha),Getdate()) as faltan from caborca_estacion_2
select max(fecha) as est3 , datediff(day,max(fecha),Getdate()) as faltan from caborca_estacion_3
select max(fecha) as est4 , datediff(day,max(fecha),Getdate()) as faltan from caborca_estacion_4
select max(fecha) as est5, datediff(day,max(fecha),Getdate()) as faltan from caborca_estacion_5

begin transaction
commit
rollback

Print @@trancount

DBCC OPENTRAN  