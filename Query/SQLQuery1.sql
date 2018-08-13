select sum(temp)/count(temp) as temp from caborca_estacion_1 where fecha >='2018/01/01' and fecha <='2018/10/01'
SET DATEFORMAT YMD 
select nombre,latitud,longitud from caborca_estaciones where id=
select fecha, PM1_1M, PM1_5M, PM1_15M, PM1_1H, PM2P5_1M, PM2P5_5M,PM2P5_15M,PM2P5_1H,PM10_1M,PM10_5M,PM10_15M,PM10_1H from caborca_estacion_1 where fecha!=(Select top(1)fecha from caborca_estacion_1)order by fecha desc
select top(10) fecha, PM1_1M, PM1_5M, PM1_15M, PM1_1H, PM2P5_1M, PM2P5_5M, PM10_1H, PM10_15M, PM10_5M,PM10_1M, PM2P5_1H,PM2P5_15M from caborca_estacion_2 order by fecha desc
select getdate()
select fecha, PM1_1M, PM1_5M, PM1_15M, PM1_1H, PM2P5_1M, PM2P5_5M, PM10_1H, PM10_15M, PM10_5M,PM10_1M, PM2P5_1H,PM2P5_15M from caborca_estacion_2 where fecha >='13/04/2018' and fecha <'14/04/2018' order by fecha
select * from caborca_estacion_2
select sum(pm1_1m)/count(pm1_1m) as pm1_1m,sum(pm1_5m)/count(pm1_5m) as pm1_5m,sum(pm1_15m)/count(pm1_15m) as pm1_15m,sum(pm1_1h)/count(pm1_1h) as pm1_1h from caborca_estacion_2 where fecha >='2018/01/01' and fecha <='2018/04/30'
select fecha from caborca_estacion_1 where fecha >='2018/09/04' and fecha <='2018/10/04'
select * from caborca_estacion_2 where fecha >='16/04/2018' and fecha <'17/04/2018'

/*delete from caborca_estacion_2 where id<=357*/

select sum(pm2p5_1m)/count(pm2p5_1m) as pm2p5_1m,sum(pm2p5_5m)/count(pm2p5_5m) as pm2p5_5m,sum(pm2p5_15m)/count(pm2p5_15m) as pm2p5_15m,sum(pm2p5_1h)/count(pm2p5_1h) as pm2p5_1h from caborca_estacion_2 where fecha >='2018/01/01' and fecha <='2018/04/30'

select fecha, PM1_1M, PM1_5M, PM1_15M, PM1_1H, PM2P5_1M, PM2P5_5M,PM2P5_15M,PM2P5_1H,PM10_1M,PM10_5M,PM10_15M,PM10_1H from caborca_estacion_2 where fecha >='13/04/2018' and fecha <'14/04/2018' order by fecha

select top(10) 
fecha, 
PM1_1M,PM1_5M,PM1_15M,PM1_1H,PM2P5_1M,PM2P5_5M,PM2P5_15M,PM2P5_1H, PM10_15M, PM10_5M,PM10_1M,PM10_1H from caborca_estacion_2 where min order by fecha desc
select pm2p5_1m from caborca_estacion_2 

select c.fecha as FECHA_DATO,a.numero as ID_ESTACION,b.nombre as MUNICIPIO,c.tmax AS TMAX,c.tmin as TMIN,c.tmed as TMED from estaciones a, municipios b,estado1diarios c  where a.municipioid=b.indice and c.numero=a.numero order by fecha desc
select top(10)* from caborca_estacion_2
select * from caborca_estacion_2

select sum(pm1_1h)/count(pm1_1h) as pm1_1h, sum(pm2p5_1h)/count(pm2p5_1h) as pm2p5_1h,sum(pm10_1h)/count(pm10_1h) as pm10_1h from caborca_estacion_2 where fecha >='16/04/2018' and fecha <'17/04/2018'

select * from estado8diarios where numero=12137 order by fecha desc and fecha >='01/01/2018' and fecha <'25/04/2018'

select * from estaciones where numero=12137

select a.numero,a.fecha,a.tmin, a.tmax from estado8diarios a, estaciones b where b.numero=49159

select x.municipioid,x.nombre,y.nombre from estaciones x, municipios y where y.nombre like '%Ahuma%'

select * from caborca_estaciones

select fecha, PM1_1M, PM1_5M, PM1_15M, PM1_1H, PM2P5_1M, PM2P5_5M,PM2P5_15M,PM2P5_1H,PM10_1M,PM10_5M,PM10_15M,PM10_1H from caborca_estacion_2 where fecha between '13/04/2018 00:00:00' and '14/04/2018 00:00:00' order by fecha


SELECT DATEADD(month, DATEDIFF(month, 0, '02/01/2018','02/03/2018'), 0) AS StartOfMonth

select fecha, PM1_1M, PM1_5M, PM1_15M, PM1_1H, PM2P5_1M, PM2P5_5M,PM2P5_15M,PM2P5_1H,PM10_1M,PM10_5M,PM10_15M,PM10_1H from caborca_estacion_2 where fecha='01/01/2018 00:00:00' or fecha='01/02/2018 00:00:00' or fecha='01/03/2018 00:00:00' or fecha='01/04/2018 00:00:00' or fecha='01/05/2018 00:00:00' or fecha='01/06/2018 00:00:00' or fecha='01/07/2018 00:00:00' or fecha='01/08/2018 00:00:00' or fecha='01/09/2018 00:00:00' or fecha='01/10/2018 00:00:00' or fecha='01/11/2018 00:00:00' or fecha='01/12/2018 00:00:00' order by fecha

insert into caborca_estacion_2 (fecha,PM1_1H,PM2P5_1H,PM10_1H)values('01/12/2018',8.7,7.3,7.4)

--delete from caborca_estacion_2 where fecha='01/05/2018'
select * from caborca_estacion_1 where fecha='17-04-2018'

select 
count(datepart(hour, fecha)) as FLAG,avg(datepart(year, fecha)) as Y,avg(datepart(month, fecha)) as M,avg(datepart(day, fecha)) as D, avg(PM1_1H) as PM1_1H, avg(PM2P5_1H) as PM2P5_1H,avg(PM10_1H) as PM10_1H
from caborca_estacion_2
where fecha>='01-01-2018' and fecha <'01-01-2019' and datepart(minute,fecha)='00' 
group by datepart(year, fecha), datepart(month, fecha), datepart(day, fecha)
having count(datepart(hour, fecha)) > = 18
order by PM1_1H, PM2P5_1H, PM10_1H


select id_usuarios,usr,pwd,nombre,apellidoM from caborca_usuarios 
select id,nombre,latitud,longitud from caborca_estaciones where id= 

select 
count(datepart(hour, fecha)) as FLAG, 
avg(datepart(year, fecha)) as Y,
avg(datepart(month, fecha)) as M,
avg(datepart(day, fecha)) as D, 
avg(PM1_1H) as PM1_1H, 
avg(PM2P5_1H) as PM2P5_1H,
avg(PM10_1H) as PM10_1H 
from caborca_estacion_1 
where fecha >='01-01-2018' and fecha <'01-01-2019' and datepart(minute,fecha)='00'
group by datepart(year, fecha), datepart(month, fecha), datepart(day, fecha)

order by Y, M, D

select * from caborca_estacion_2 where datepart(minute, fecha))='00' and fecha between '28-01-2019'

select *
from caborca_estacion_1 
where fecha >='01-01-2018' and fecha <'04-02-2019' and datepart(minute,fecha)='00'
order by fecha

/*avg to year*/
select 
count(datepart(hour, fecha)) as FLAG,
avg(datepart(year, fecha)) as Y,
avg(datepart(month, fecha)) as M,
count(datepart(day,fecha)) as D, 
avg(PM1_1H) as PM1_1H, 
avg(PM2P5_1H) as PM2P5_1H,
avg(PM10_1H) as PM10_1H 
from caborca_estacion_1 
where fecha >='01-01-2018' and fecha <'01-01-2019' and datepart(minute,fecha)='00'
group by datepart(year, fecha), datepart(month, fecha)
having count(datepart(hour, fecha)) > = 18
order by Y, M

select 
count(datepart(hour, fecha)) as FLAG, 
avg(datepart(year, fecha)) as Y,
avg(PM1_1H) as PM1_1H, 
avg(PM2P5_1H) as PM2P5_1H,
avg(PM10_1H) as PM10_1H 
from caborca_estacion_1 
where fecha >='01/01/2018' and fecha <'01/01/2018' and datepart(minute,fecha)='00' 
group by datepart(year, fecha), datepart(month, fecha) 
having count(datepart(hour, fecha)) > = 18 order by Y, M 

