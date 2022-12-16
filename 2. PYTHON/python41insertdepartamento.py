import pyodbc

print("Insertar departamento")
servidor = "LOCALHOST"
bbdd = "HOSPITAL"
usuario = "SA"
password = ""
connectionString = "DRIVER={ODBC Driver 17 for SQL Server}; SERVER=" + servidor + "; DATABASE=" + bbdd + ";UID=" + usuario + ";PWD=" + password
conexion = pyodbc.connect(connectionString)
# VAMOS A PEDIR LOS DATOS AL USUARIO Y LOS UTILIZAREMOS
# PARA CONCATENAR Y REALIZAR NUESTRA CONSULTA INSERT
# POR LO QUE, AL CONCATENAR, LOS DATOS SERAN STRING AUNQUE
# SEAN DATOS NUMERICOS
print("Introduzca un número")
numero = input()
print("Introduzca nombre de departamento")
nombre = input()
print("Introduzca localidad")
localidad = input()
# DEBEMOS CONCATENAR LOS VALORES.  LO MAS COMODO ES IR 
# SIGUIENDO UNA CONSULTA YA REALIZADA
# "insert into dept values (66, 'PYTHON', 'ALMERIA')"
sql = "insert into dept values(" + numero + ", '" + nombre + "', '" + localidad + "')"
print(sql)
# DECLARAMOS NUESTRO CURSOR
cursor = conexion.cursor()
# EJECUTAMOS LA CONSULTA SOBRE EL CURSOR
cursor.execute(sql)
# CUANDO EJECUTAMOS CONSULTAS DE ACCION
# PARA AVERIGUAR EL NUMERO DE REGISTROS QUE
# HAN SIDO AFECTADOS POR LA CONSULTA SE UTILIZA 
# LA PROPIEDAD rowcount DEL CURSOR
filasInsertadas = cursor.rowcount
print("Rowcount: " + str(filasInsertadas))
# EN PYTHON, LAS CONSULTAS DE ACCION SE REALIZAN
# DE FORMA TEMPORAL, ES DECIR, NO SON LLEVADAS A LA 
# BBDD HASTA QUE NO SE LO DECIMOS EXPLICITAMENTE MEDIANTE
# EL METODO commit() DEL CURSOR
cursor.commit()
# CON ROLLBACK LE INDICAMOS QUE DESHAGA LOS CAMBIOS
# cursor.rollback()
cursor.close()
# LOS CURSORES SE PUEDEN REUTILZAR PARA DIFERENTES CONSULTAS
# VAMOS A REUTILIZAR ESTA MISMA VARIABLE A CONTINUACION 
# PARA UNA CONSULTA DE SELECCION
# COMO NECESITAMOS LA CONEXION ABIERTA, NO CERRAMOS LA CONEXION
sqlselect = "SELECT * FROM DEPT"
# VOLVEMOS A CARGAR EL CURSOR DE NUEVO PARA LA 
# SIGUIENTE CONSULTA
cursor = conexion.cursor()
# EJECUTAMOS LA CONSULTA SELECT
cursor.execute(sqlselect)
print("--------------Departamentos----------------")
for row in cursor:
    print(row.DNOMBRE + ", " + row.LOC)
# CERRAMOS EL CURSOR
cursor.close()
conexion.close()
print("Fin de programa")