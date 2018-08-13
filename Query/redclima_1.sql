select 
E.nombre,
M.nombre,
avg(S.numero), 
avg(datepart(year, fecha)) as anio, 
avg(datepart(month, fecha)) as mes, 
avg(datepart(day, fecha)) as dia,  
datepart(hour, fecha) as hora, 
avg(T.prec) as Prec, 
avg(T.temt) as avgTemp, 
avg(T.dirv) as avgDirv, 
avg(T.velv) as avgVelv, 
avg(T.radg) as avgRadg, 
avg(T.humh) as avgHumh
from estado1 T,estaciones S, estados E, municipios M
where S.numero=T.numero and S.estadoid=E.indice and S.municipioid=M.indice and fecha>='01-01-2015' and fecha<'01-02-2017'
group by E.nombre,M.Nombre,datepart(year, fecha), datepart(month, fecha), datepart(day, fecha), datepart(hour,fecha) 
union
select 
E.nombre,
M.nombre,
avg(S.numero), 
avg(datepart(year, fecha)) as anio, 
avg(datepart(month, fecha)) as mes, 
avg(datepart(day, fecha)) as dia,  
datepart(hour, fecha) as hora, 
avg(T.prec) as Prec, 
avg(T.temt) as avgTemp, 
avg(T.dirv) as avgDirv, 
avg(T.velv) as avgVelv, 
avg(T.radg) as avgRadg, 
avg(T.humh) as avgHumh
from estado2 T,estaciones S, estados E, municipios M
where S.numero=T.numero and S.estadoid=E.indice and S.municipioid=M.indice and fecha>='01-01-2015' and fecha<'01-02-2017'
group by E.nombre,M.Nombre,datepart(year, fecha), datepart(month, fecha), datepart(day, fecha), datepart(hour,fecha) 
order by E.nombre,M.Nombre,anio, mes, dia, hora

Select Fecha,Temt,Prec,Eto From Estado1 Where numero=22 and fecha between '01-01-2017' and '02-01-2017' order by fecha

select * from estaciones where estadoid=1