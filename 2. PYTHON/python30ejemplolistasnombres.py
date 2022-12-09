nombres = []

def showNombres():
    for i in range(len(nombres)):
        name = nombres[i]
        print(str(i) + ".- " + name)

def rellenarNombres():
    # LIMPIAMOS LA LISTA
    nombres.clear()
    # BUCLE HASTA OK
    respuesta = ""
    while (respuesta.upper() != "OK"):
        print("Introduzca un nombre o escriba OK para continuar")
        respuesta = input()
        if (respuesta.upper() != "OK"):
            nombres.append(respuesta)
            print("Datos almacenados " + str(len(nombres)))

print("Programa Listas de nombres")
rellenarNombres()
print("-------------------------------")
print("Lista de nombres almacenados correctamente")
showNombres()
try:
    opcion = -1
    while(opcion != 0):
        print("----------------")
        print("0.- Salir")
        print("1.- Nuevo nombre")
        print("2.- Eliminar nombre")
        print("3.- Comenzar de nuevo")
        print("Seleccione una opción")
        opcion = int(input())
        if (opcion == 1):
            print("Introduzca un nuevo nombre")
            nombre = input()
            nombres.append(nombre)
            showNombres()
        elif (opcion == 2):
            showNombres()
            print("Introduzca el indice a eliminar")
            indice = int(input())
            nombres.pop(indice)
            print("Nombre eliminado")
            showNombres()
        elif (opcion == 3):
            rellenarNombres()
            showNombres()
        elif (opcion == 0):
            print("Saliendo del programa")
        else:
            print("Opción incorrecta")
except IndexError:
    print("Ha introducido un Index no VALIDO")
except ValueError:
    print("Debe introducir una opción válidad")
finally:
    print("Fin de programa")