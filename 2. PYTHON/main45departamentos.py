from conexion45departamentos import ConexionDepartamentos
from class45departamento import Departamento
connection = ConexionDepartamentos()
print("Clase acceso a datos Departamentos")
print("1.- Insertar departamento")
print("2.- Modificar departamento")
print("3.- Eliminar departamento")
print("4.- Buscar departamento")
print("5.- Mostrar todos los departamentos")
print("Seleccione una opción")
opcion = int(input())
if (opcion == 1):
    print("Número de departamento")
    numero = input()
    print("Nombre de departamento")
    nombre = input()
    print("Localidad del departamento")
    localidad = input()
    respuesta = connection.insertarDepartamento(numero, nombre, localidad)
    print("Departamentos insertados: " + str(respuesta))
elif (opcion == 2):
    print("Nuevo nombre departamento")
    nombre = input()
    print("Nueva localidad")
    localidad = input()
    print("ID departamento a modificar")
    numero = input()
    respuesta = connection.modificarDepartamento(numero, nombre, localidad)
    print("Departamentos modificados: " + str(respuesta))
elif (opcion == 3):
    print("ID departamento a eliminar")
    numero = input()
    respuesta = connection.eliminarDepartamento(numero)
    print("Departamentos eliminados: " + str(respuesta))
elif (opcion == 4):
    print("Introduzca ID a buscar")
    numero = input()
    dept = connection.buscarDepartamento(numero)
    if (not dept):
        print("No existe departamento")
    else:
        print(dept.nombre + ", " + dept.localidad)
elif (opcion == 5):
    departamentos = connection.getDepartamentos()
    for dept in departamentos:
        print(dept.nombre + ", " + dept.localidad)
else:
    print("Opción incorrecta")
print("Fin de programa")