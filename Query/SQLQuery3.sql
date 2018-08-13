select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado1diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'

union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado2diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado3diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado4diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado5diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado6diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado7diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado8diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado9diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado10diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado11diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado12diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado13diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado14diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado15diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado16diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado17diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado18diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado19diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado20diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado21diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado22diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado23diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado24diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado26diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado27diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado28diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado29diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado30diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado31diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
union
select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV,
d.fecha as FECHA 
from estados e, municipios m,estaciones c,estado32diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'
