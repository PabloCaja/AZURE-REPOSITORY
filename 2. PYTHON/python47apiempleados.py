import requests
import json

print("Consumo Api empleados")
url = "https://apiempleadosspgs.azurewebsites.net/"
print("1.- Todos los empleados")
print("2.- Buscar empleado")
print("Seleccione una opción")
opcion = int(input())
if (opcion == 1):
    peticion = "api/empleados"
    # REALIZAMOS UNA PETICION GET Y CAPTURAMOS LA RESPUESTA
    response = requests.get(url + peticion)
    # CONVERTIMOS LA RESPUESTA A DICCIONARIO JSON
    empleados = response.json()
    # UN DICCIONARIO PODEMOS RECORRERLO SI ES UN CONJUNTO
    print("Listado de empleados Api")
    for emp in empleados:
        print(emp["apellido"])
elif (opcion == 2):
    print("Introduzca ID empleado")
    idempleado = input()
    peticion = "api/empleados/" + idempleado
    response = requests.get(url + peticion)
    empleado = response.json()
    print(empleado["apellido"] + ", " + empleado["oficio"] + ", " + str(empleado["salario"]))
else:
    print("Opción incorrecta")
print("Fin de programa")