import pyodbc
import pandas as pd
import numpy as np
import os

def main():

	server = "10.20.55.34"
	database = "Caborca"
	usr = "intranet"
	pwd = "Newl@b0ratorio"

	conn = pyodbc.connect('DRIVER={SQL Server};SERVER='+server+';DATABASE='+database+';UID='+usr+';PWD='+ pwd)
	cursor =  conn.cursor()
	cursor.execute("begin transaction");
	for i in range(1,6):
		nombre_del_archivo = "d/estacion_{}.csv".format(i)

		cols = ["PM1_1M", "PM1_5M", "PM1_15M", "PM1_1H", "PM2P5_1M", "PM2P5_5M",  "PM2P5_15M", "PM2P5_1H", "PM10_1M", "PM10_5M", "PM10_15M", "PM10_1H", "temp", "supply"]
		
		df = pd.read_csv(nombre_del_archivo, index_col=False)

		df["Time"] = pd.to_datetime(df["Time"])

		#df.columns = cols

		print(nombre_del_archivo)

		# validación de contenido
		if df["Time"].count() > 1:
			for index, row in df.iterrows():
				fecha = row["Time"]
				print("*****************", fecha)
				pm1_1m = eliminar_nulos(row["PM1_1M"])
				pm1_5m = eliminar_nulos(row["PM1_5M"])
				pm1_15m = eliminar_nulos(row["PM1_15M"])
				pm1_1h = eliminar_nulos(row["PM1_1H"])
				pm2p5_1m = eliminar_nulos(row["PM2P5_1M"])
				pm2p5_5m = eliminar_nulos(row["PM2P5_5M"])
				pm2p5_15m = eliminar_nulos(row["PM2P5_15M"])
				pm2p5_1h = eliminar_nulos(row["PM2P5_1H"])
				pm10_1m = eliminar_nulos(row["PM10_1M"])
				pm10_5m = eliminar_nulos(row["PM10_5M"])
				pm10_15m = eliminar_nulos(row["PM10_15M"])
				pm10_1h = eliminar_nulos(row["PM10_1H"])
				temp = eliminar_nulos(row["temp"])
				supp = eliminar_nulos(row["supply"])

				print(pm1_1m,
				pm1_5m,
				pm1_15m,
				pm1_1h,
				pm2p5_1m,
				pm2p5_5m,
				pm2p5_15m,
				pm2p5_1h,
				pm10_1m,
				pm10_5m,
				pm10_15m,
				pm10_1h,
				temp,
				supp)


				# generar query
				query = "INSERT INTO caborca_estacion_{} (fecha, PM1_1M, PM1_5M, PM1_15M, PM1_1H, PM2P5_1M, PM2P5_5M,  PM2P5_15M, PM2P5_1H, PM10_1M, PM10_5M, PM10_15M, PM10_1H, temp, supply) VALUES ((?), (?), (?), (?), (?), (?), (?), (?), (?), (?), (?), (?), (?), (?), (?))".format(i)
				# ejecutar insert
				print(query)

				cursor.execute(query, (fecha, pm1_1m, pm1_5m, pm1_15m, pm1_1h, pm2p5_1m, pm2p5_5m, pm2p5_15m, pm2p5_1h, pm10_1m, pm10_5m, pm10_15m, pm10_1h, temp, supp))

				cursor.commit()

	print("Revisar la base de datos -------------------------- ")
	confirmar=input("confirmar (Y=1/N=0): ")
	if confirmar=='1':
		cursor.execute("commit")
		conn.close()
	else:
		cursor.execute("rollback")

def eliminar_nulos(v):
	if np.isnan(v):
		return 0.0
	else:
		return v 

if __name__ == '__main__':
	main()

