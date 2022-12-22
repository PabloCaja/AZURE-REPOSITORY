import pyodbc
try:
    connection =pyodbc.connect('DRIVER={SQL Server}; SERVER=LOCALHOST\SQLEXPRESS;DATABASE=HOSPITAL; UID=sa; PWD=')
    print("conexion exitosa")
except Exception as ex:
    print (ex)    
    