import pyodbc

server = "10.20.55.34"
database = "Caborca"
usr = "intranet"
pwd = "Newl@b0ratorio"

conn = pyodbc.connect('DRIVER={SQL Server};SERVER='+server+';DATABASE='+database+';UID='+usr+';PWD='+ pwd)
cursor =  conn.cursor()
cursor.execute("select * from caborca_usuarios")
rows = cursor.fetchall()

for row in rows:
	print(row)