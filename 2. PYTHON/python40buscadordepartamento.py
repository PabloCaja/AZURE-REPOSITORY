import pyodbc
print("Buscador departamentos")
servidor = "LOCALHOST"
bbdd = "HOSPITAL"
usuario = "SA"
password = ""
connectionString = "DRIVER={ODBC Driver 17 for SQL Server}; SERVER=" + servidor + "; DATABASE=" + bbdd + ";UID=" + usuario + ";PWD=" + password
# NOS CONECTAMOS
conexion = pyodbc.connect(connectionString)
# PEDIMOS UN NUMERO DE DEPARTAMENTO AL USUARIO
print("Introduzca un número de departamento")
# EL USUARIO NOS DARA UN NUMERO, QUE NOSOTROS VAMOS A 
# UTILIZAR PARA CONCATENAR A LA CONSULTA, POR LO QUE, 
# AUNQUE SEA UN NUMERO, ES UN DATO STRING
data = input()
sql = "select * from DEPT where DEPT_NO=" + data
# SOLAMENTE DEVOLVERA UNA FILA, YA QUE BUSCAMOS POR EL ID
cursor = conexion.execute(sql)
row = cursor.fetchone()
# PARA PREGUNTAR SI TENEMOS DATOS O NO EN LA FILA
# SE UTILIZA EL OPERADOR not
if (not row):
    print("No existe el departamento " + data)
else:
    print(row.DNOMBRE + ", " + row.LOC)
cursor.close()
conexion.close()
print("Fin de programa")
