select
e.nombre as ESTADO,
m.nombre as MUNICIPIO,
DATEPART(YYYY,d.fecha) AS AÑO,
DATEPART(MM,d.fecha) AS MES,
DATEPART(DD,d.fecha) AS DIA,
DATEPART(HH, d.fecha) AS HORA,
DATEPART(mi, d.fecha) AS MINUTO,
c.numero as NoESTACION,
d.tmax as TEMP_MAX, 
d.tmin as TEMP_MIN,
d.tmed as TEMP_MED,
d.velvmax as VEL_VIENTO_MAX,
d.velv as VEL_VIENTO,
d.dirvvmax as DIR_VIENTO_MAX,
d.dirv as DIR_VIENTO,
d.radg as RAD_SOLAR,
d.humr as HUM_REALTV
from estados e, municipios m,estaciones c,estado1diarios d
where c.numero=d.numero and c.estadoid=e.indice and c.municipioid = m.indice and d.fecha >= '01/01/2015' and d.fecha < '01/01/2017'