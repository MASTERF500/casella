select * from caborca_estacion_3 where PM1_1H=0



-- pm1 134
-- pm2.5 300
-- pm10 


select count(datepart(hour, fecha)) as FLAG, 
avg(datepart(year, fecha)) as Y,
avg(datepart(month, fecha)) as M,
avg(datepart(day, fecha)) as D, 
avg(PM1_1H) as PM1_1H, 
avg(PM2P5_1H) as PM2P5_1H,
avg(PM10_1H) as PM10_1H 
from caborca_estacion_1 
where 
fecha >='01/01/2018' 
and fecha <'01/06/2018' 
and datepart(minute,fecha)='00' 

group by datepart(year, fecha), datepart(month, fecha), datepart(day, fecha) 
order by Y, M, D

select * from caborca_estacion_ where PM1_1H =0 


union
SELECT [fecha], [PM1_1H], [PM2P5_1H], [PM10_1H], [temp], [supply] FROM caborca_estacion_2 where PM2P5_1H!=0
union
SELECT [fecha], [PM1_1H], [PM2P5_1H], [PM10_1H], [temp], [supply] FROM caborca_estacion_3 where PM10_1H!=0
order by PM1_1H

select 15891 - 16668
select distinct count([PM1_1H]) + count([PM2P5_1H]) + count([PM10_1H]) from caborca_estacion_1 where [PM1_1H]=0 or [PM2P5_1H]=0 or [PM10_1H]=0

SELECT [fecha], [PM1_1H], [PM2P5_1H], [PM10_1H], [temp], [supply] FROM caborca_estacion_2 where PM1_1H!=0 and PM2P5_1H!=0 and PM10_1H!=0
order by PM1_1H

select [fecha], [PM1_1H], [PM2P5_1H], [PM10_1H], [temp], [supply] from caborca_estacion_2 
where fecha between '01/01/2018' and '01/07/2018' 
and DATEPART(MINUTE,fecha) = '00' and PM1_1H!=0 
and PM2P5_1H!=0 and PM10_1H!=0
order by fecha

-- consulta para Trimestre
select 
count(datepart(hour, fecha)) as FLAG,
avg(datepart(year, fecha)) as Y,
avg(datepart(month, fecha)) as M,
avg(datepart(day, fecha)) as D, 
avg(PM1_1H) as PM1_1H, 
avg(PM2P5_1H) as PM2P5_1H,
avg(PM10_1H) as PM10_1H 
from caborca_estacion_1 
where fecha between '01/01/2018' and '01/07/2018'
and datepart(minute,fecha)='00' 
and PM1_1H!=0 and PM2P5_1H!=0 and PM10_1H!=0
group by datepart(year, fecha), 
datepart(month, fecha), 
datepart(day, fecha)
having count(datepart(hour, fecha)) > = 18  
order by Y, M, D

-- consulta datos del dia.
select fecha,PM1_1M, PM1_5M, PM1_15M, PM1_1H, PM2P5_1M, PM2P5_5M,PM2P5_15M,PM2P5_1H,PM10_1M,PM10_5M,PM10_15M,PM10_1H from caborca_estacion_1 
where DATEPART(YEAR,fecha)=2018 and datepart(MONTH,fecha )= 2 and DATEPART(DAY,fecha) =19 
and datepart(minute,fecha)='00' and PM1_1H!=0 and PM2P5_1H!=0 and PM10_1H!=0

-- consulta para Anual

select 
count(datepart(hour, fecha)) as FLAG,
avg(datepart(year, fecha)) as Y,
avg(datepart(month, fecha)) as M,
avg(datepart(day, fecha)) as D, 
avg(PM1_1H) as PM1_1H, 
avg(PM2P5_1H) as PM2P5_1H,
avg(PM10_1H) as PM10_1H 
from caborca_estacion_1 
where fecha between '01/01/2018' and '01/07/2018'
and PM1_1H!=0 and PM2P5_1H!=0 and PM10_1H!=0
and datepart(minute,fecha)='00' 
group by datepart(year, fecha), 
datepart(month, fecha), 
datepart(day, fecha)
having count(datepart(DAY, fecha)) > = 18
order by Y, M, D


declare @dias int,@contador int,@fecha datetime
declare @tablaDias table(dia datetime)
set @dias  = 365
set @contador = 0
while @contador <=365
begin 
   insert into @tablaDias(dia)values(dateadd(day,@contador,'2018-01-01'))
   set @contador = @contador + 1 
END
--select * from @tablaDias where DATEPART(MONTH,dia) in (1,2,3) order by dia
select * from @tablaDias order by dia

select DATEDIFF(DAYOFYEAR,'01/08/2018','01/09/2018')
go

select * from estado1 where numero=22 and DATEPART(YEAR,fecha) = 2018 and DATEPART(MONTH,fecha) = 07 and DATEPART(DAY,fecha) =1
select * from estado1diarios where numero=22 and DATEPART(YEAR,fecha) = 2018 and DATEPART(MONTH,fecha) = 07 and DATEPART(DAY,fecha) =1
select 
sum(prec) as prec,
max(temt) as tmax,
min(temt) as tmin,
avg(temt) as tmed,
max(velv) as velvmax,
velv,
max(dirv) as dirvvmax,
avg(dirv) as dirv,
avg(radg) as radg,
avg(humr) as humr,

eto
from estado1 
where numero=22 
and DATEPART(YEAR,fecha) = 2018 
and DATEPART(MONTH,fecha) = 07 
and DATEPART(DAY,fecha) =1

select COUNT(*) from estado1


select * from caborca_estacion_1 

