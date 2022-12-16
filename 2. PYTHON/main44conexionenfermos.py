# UTILIZAMOS EXPLICITAMENTE PYODBC??
# QUE CLASE UTILIZA LOS CURSORES Y LAS CONSULTAS SQL??
from conexion44enfermos import ConexionEnfermos

# CREAMOS UN OBJETO DE LA CLASE CONEXIONENFERMOS
connection = ConexionEnfermos()
print("Escriba una inscripción")
inscripcion = input()
print("Escriba el nuevo apellido del enfermo")
apellido = input()
respuesta = connection.modificarEnfermo(apellido, inscripcion)
print("Apellidos modificados: " + str(respuesta))
# LA CLASE CONEXION NOS DEVUELVE EL NUMERO DE ENFERMOS
# ELIMINADOS
# respuesta = connection.eliminarEnfermo(inscripcion)
# print("Enfermos eliminados: " + str(respuesta))
print("Fin de programa")
