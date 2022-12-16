import requests
import json

print("Ejemplo Api Crud Departamentos")
url = "https://apicruddepartamentoscore.azurewebsites.net/"
print("1.- Mostrar departamentos")
print("2.- Insertar departamento")
print("3.- Modificar departamento")
print("4.- Eliminar departamento")
print("Seleccione una opción")
opcion = int(input())
if (opcion == 1):
    peticion = "api/departamentos"
    response = requests.get(url + peticion)
    departamentos = response.json()
    for dept in departamentos:
        print(str(dept["numero"]) + ", " + dept["nombre"] + ", " + dept["localidad"])
elif (opcion == 2):
    print("-----------Nuevo departamento--------------")
    print("Introduzca ID departamento")
    numero = int(input())
    print("Introduzca nombre departamento")
    nombre = input()
    print("Introduzca una localidad")
    loc = input()
    peticion = "api/departamentos"
    # CREAMOS UN OBJETO JSON DE TIPO DICCIONARIO
    departamento = {
        "numero": numero,
        "nombre": nombre,
        "localidad": loc
    }
    print(departamento)
    response = requests.post(url + peticion, json=departamento)
    # DIBUJAMOS LA RESPUESTA DEL SERVICIO
    print("Status: " + str(response.status_code))
elif (opcion == 3):
    peticion = "api/departamentos"
    print("---------Modificar departamento----------")
    print("Introduzca ID departamento a modificar")
    numero = int(input())
    print("Introduzca nuevo nombre departamento")
    nombre = input()
    print("Introduzca nueva localidad")
    loc = input()
    departamento = {
        "numero": numero,
        "nombre": nombre,
        "localidad": loc
    }
    response = requests.put(url + peticion, json=departamento)
    print("Status: " + str(response.status_code))
elif (opcion == 4):
    print("------------Eliminar departamento----------")
    print("Introduzca ID departamento a eliminar")
    numero = input()
    peticion = "api/departamentos/" + numero
    response = requests.delete(url + peticion)
    print("Status: " + str(response.status_code))
else:
    print("Opción incorrecta")
print("Fin de programa")