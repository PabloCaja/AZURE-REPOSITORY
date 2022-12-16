import pyodbc

print("Incrementar salario empleados")
servidor = "LOCALHOST"
bbdd = "HOSPITAL"
usuario = "SA"
password = ""
connectionString = "DRIVER={ODBC Driver 17 for SQL Server}; SERVER=" + servidor + "; DATABASE=" + bbdd + ";UID=" + usuario + ";PWD=" + password
conexion = pyodbc.connect(connectionString)
cursor = conexion.cursor()
sqlselect = "SELECT inscripcion, apellido FROM ENFERMO"
cursor.execute(sqlselect)
print("-------------Listado de enfermos-------------------")
for inscripcion, apellido in cursor:
    print(str(inscripcion) + " - " + apellido)
cursor.close()
print("Introduzca INSCRIPCION para eliminar un enfermo")
inscripcion = input()
cursor = conexion.cursor()
sqldelete = "DELETE FROM ENFERMO WHERE INSCRIPCION=?"
cursor.execute(sqldelete, (inscripcion))
filasEliminadas = cursor.rowcount
cursor.commit()
print("Registros eliminados: " + str(filasEliminadas))
cursor.close()
conexion.close()
print("Fin de programa")