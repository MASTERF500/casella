select 
sum(pm1_1m)/count(pm1_1m) as pm1_1m,
sum(pm1_5m)/count(pm1_5m) as pm1_5m,
sum(pm1_15m)/count(pm1_15m) as pm1_15m,
sum(pm1_1h)/count(pm1_1h) as pm1_1h
from caborca_estacion_2 where fecha >= '15/04/2018' and fecha <= '19/04/2018'

select 
sum(pm2p5_1m)/count(pm2p5_1m) as pm2p5_1m,
sum(pm2p5_5m)/count(pm2p5_5m) as pm2p5_5m,
sum(pm2p5_15m)/count(pm2p5_15m) as pm2p5_15m,
sum(pm2p5_1h)/count(pm2p5_1h) as pm2p5_1h
from caborca_estacion_2 where fecha >= '16/04/2018' and fecha <= '19/04/2018'

select 
sum(pm10_1m)/count(pm10_1m) as pm10_1m,
sum(pm10_5m)/count(pm10_5m) as pm10_5m,
sum(pm10_15m)/count(pm10_15m) as pm10_15m,
sum(pm10_1h)/count(pm10_1h) as pm10_1h
from caborca_estacion_2 where fecha >= '18/04/2018' and fecha <= '19/04/2018'

select sum(temp)/count(temp) as temp from caborca_estacion_1 where fecha>'18/04/2017' 

select 
sum(pm1_1m)/count(pm1_1m) as pm1_1m,
sum(pm1_5m)/count(pm1_5m) as pm1_5m,
sum(pm1_15m)/count(pm1_15m) as pm1_15m,
sum(pm1_1h)/count(pm1_1h) as pm1_1h,
sum(pm2p5_1m)/count(pm2p5_1m) as pm2p5_1m,
sum(pm2p5_5m)/count(pm2p5_5m) as pm2p5_5m,
sum(pm2p5_15m)/count(pm2p5_15m) as pm2p5_15m,
sum(pm2p5_1h)/count(pm2p5_1h) as pm2p5_1h,
sum(pm10_1m)/count(pm10_1m) as pm10_1m,
sum(pm10_5m)/count(pm10_5m) as pm10_5m,
sum(pm10_15m)/count(pm10_15m) as pm10_15m,
sum(pm10_1h)/count(pm10_1h) as pm10_1h
from caborca_estacion_1 where fecha > '18/04/2017' 

select sum(pm1_1m)/count(pm1_1m) as pm1_1m,sum(pm1_5m)/count(pm1_5m) as pm1_5m,sum(pm1_15m)/count(pm1_15m) as pm1_15m,sum(pm1_1h)/count(pm1_1h) as pm1_1h,sum(pm2p5_1m)/count(pm2p5_1m) as pm2p5_1m,sum(pm2p5_5m)/count(pm2p5_5m) as pm2p5_5m,sum(pm2p5_15m)/count(pm2p5_15m) as pm2p5_15m,sum(pm2p5_1h)/count(pm2p5_1h) as pm2p5_1h,sum(pm10_1m)/count(pm10_1m) as pm10_1m,sum(pm10_5m)/count(pm10_5m) as pm10_5m,sum(pm10_15m)/count(pm10_15m) as pm10_15m,sum(pm10_1h)/count(pm10_1h) as pm10_1h from caborca_estacion_2 where fecha >='01/04/2018' and fecha <='30/04/2018' order by fecha
select fecha,sum(pm1_1m)/count(pm1_1m) as pm1_1m,sum(pm1_5m)/count(pm1_5m) as pm1_5m,sum(pm1_15m)/count(pm1_15m) as pm1_15m,sum(pm1_1h)/count(pm1_1h) as pm1_1h,sum(pm2p5_1m)/count(pm2p5_1m) as pm2p5_1m,sum(pm2p5_5m)/count(pm2p5_5m) as pm2p5_5m,sum(pm2p5_15m)/count(pm2p5_15m) as pm2p5_15m,sum(pm2p5_1h)/count(pm2p5_1h) as pm2p5_1h,sum(pm10_1m)/count(pm10_1m) as pm10_1m,sum(pm10_5m)/count(pm10_5m) as pm10_5m,sum(pm10_15m)/count(pm10_15m) as pm10_15m,sum(pm10_1h)/count(pm10_1h) as pm10_1h from caborca_estacion_2 where fecha >='' and fecha <='' order by fecha

select fecha,pm1_1m,pm1_5m
from caborca_estacion_2
where fecha >='01/04/2018' and fecha <='30/04/2018' order by fecha asc