import pyodbc

print("Incrementar salario empleados")
servidor = "LOCALHOST"
bbdd = "HOSPITAL"
usuario = "SA"
password = ""
connectionString = "DRIVER={ODBC Driver 17 for SQL Server}; SERVER=" + servidor + "; DATABASE=" + bbdd + ";UID=" + usuario + ";PWD=" + password
conexion = pyodbc.connect(connectionString)
print("Introduzca un Oficio")
oficio = input()
print("Introduzca incremento salarial")
incremento = input()
cursor = conexion.cursor()
sqlupdate = "UPDATE EMP SET SALARIO=SALARIO + ? WHERE OFICIO=?"
cursor.execute(sqlupdate, (incremento, oficio))
filasModificadas = cursor.rowcount
print("Registros modificados: " + str(filasModificadas))
cursor.commit()
cursor.close()
cursor = conexion.cursor()
sqlselect = "SELECT * FROM EMP WHERE OFICIO=?"
cursor.execute(sqlselect, (oficio))
print("-------------Empleados---------------")
for row in cursor:
    print(row.APELLIDO + ", " + row.OFICIO + ", " + str(row.SALARIO))
cursor.close()
conexion.close()
print("Fin de programa")
