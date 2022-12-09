# DECLARAMOS COLECCION PARA ALMACENAR CIUDADES
ciudades = []

def showCiudades():
    print("Numero de ciudades " + str(len(ciudades)))
    for ciudad in ciudades:
        print(ciudad)

# METODO PARA LEER LAS CIUDADES DE UN ARCHIVO
def readFile():
    fichero = open("ciudades.txt", "r")
    contenido = fichero.read()
    fichero.close()
    global ciudades
    # ALMACENAMOS EN CIUDADES LA INFORMACION RECUPERADA
    ciudades = contenido.split(sep="@")
    print("Datos cargados correctamente")
    print("Numero de ciudades " + str(len(ciudades)))

# METODO PARA GUARDAR LAS CIUDADES EN UN FICHERO
def saveFile():
    #CONVERTIMOS LA LISTA A STRING CON UN SEPARADOR
    resultado = "@".join(ciudades)
    fichero = open("ciudades.txt", "w+")
    fichero.write(resultado)
    fichero.flush()
    fichero.close()
    print("Datos almacenados correctamente")

# METODO PARA AÑADIR CIUDADES A LA COLECCION
def insertarCiudad():
    print("Introduzca nombre de ciudad")
    ciudad = input()
    ciudades.append(ciudad)

print("Ejemplo ciudades y Files")
opcion = -1
while (opcion != 0):
    print("0.- Salir")
    print("1.- Leer File ciudades")
    print("2.- Guardar File ciudades")
    print("3.- Nueva ciudad")
    print("4.- Mostrar ciudades")
    print("Seleccione una opción")
    opcion = int(input())
    if (opcion == 1):
        readFile()
    elif (opcion == 2):
        saveFile()
    elif (opcion == 3):
        insertarCiudad()
    elif (opcion == 4):
        showCiudades()
    elif (opcion == 0):
        print("Saliendo del programa")
    else:
        print("Opción incorrecta")

print("Fin de programa")