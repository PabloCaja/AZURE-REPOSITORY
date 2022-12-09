import pyodbc
print("Primera consulta SQL Server")
servidor="LOCALHOST\SQLEXPRESS"
bbdd="HOSPITAL"
usuario="SA"
password=""
# servidor = "sqleoi.database.windows.net"
# bbdd = "AZUREALUMNOS"
# usuario = "adminsql"
# password = "Admin123"
#CADENA CONEXION CON SEGURIDAD SQL SERVER (REMOTO)
cadenaconexion=("DRIVER={ODBC Driver 17 for SQL Server};SERVER=" + servidor
+ "; DATABASE=" + bbdd + "; UID=" + usuario + "; PWD=" + password)
try:
    print("Intentando conectar...")
    conexion = pyodbc.connect(cadenaconexion)
    print("Conectado!!!")
except pyodbc.InterfaceError:
    print("Buff, esto no va bien")
finally:
    conexion.close()
print("Fin de programa")
