import pyodbc

print("Primera consulta SELECT Python")
servidor = "LOCALHOST\SQLEXPRESS"
bbdd = "HOSPITAL"
usuario = "SA"
password = ""
# CREAMOS NUESTRA CADENA DE CONEXION
connection = 'DRIVER={SQL Server}; SERVER=LOCALHOST\SQLEXPRESS; DATABASE=HOSPITAL; UID=sa; PWD=2699'
# CONECTAMOS CON NUESTRA BBDD
print("Intentando conectar....")
#conexion = pyodbc.connect(connectioString)
print("Conectado a SQL Server")
# TENEMOS UNA CONEXION ABIERTA, PODEMOS REALIZAR CONSULTAS
# CREAMOS UN CURSOR PARA REALIZAR UNA CONSULTA
cursor = conexion.cursor()
# EL CURSOR MANEJA TANTO CONSULTAS DE SELECCION 
# COMO CONSULTAS DE ACCION, LE ES INDIFERENTE
# CREAMOS NUESTRA CONSULTA SELECT python39consultaselect.py
sql = "select * from DEPT"
# EL CURSOR ES EL ENCARGADO DE EJECUTAR LA CONSULTA
cursor.execute(sql)
# LOS NOMBRES DE COLUMNA SON CASE SENSITIVE
# UTILIZAMOS UN BUCLE FOR
for numero, nombre, localidad in cursor:
    print(str(numero) + ", Nombre: " + nombre + ", Localidad: " + localidad)
    # PODEMOS DIBUJAR POR EL INDICE DE LA COLUMNA
    # EMPEZANDO EN CERO
    # DIBUJAMOS POR POSICION, QUE CORRESPONDE A LA 
    # COLUMNA DNOMBRE
    # print(row[1])
    # TAMBIEN PODEMOS DIBUJAR CON EL NOMBRE DE 
    # LA COLUMNA DE FORMA DINAMICA
    # print(row.loc)
# UN CURSOR SOLAMENTE SE LEE UNA VEZ.
# SI NECESITAMOS LEER LOS DATOS DE NUEVO, TENDRIAMOS
# QUE EJECUTAR LA CONSULTA DE NUEVO...
row = cursor.fetchone()
print(row)
# DEBEMOS CERRAR EL CURSOR DESPUES DE UTILIZARLO
cursor.close()
# CERRAMOS LA CONEXION
conexion.close()
print("Fin de programa")
