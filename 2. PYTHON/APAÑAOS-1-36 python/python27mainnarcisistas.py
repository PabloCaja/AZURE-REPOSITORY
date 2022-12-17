import python27metodosnarcistas
import datetime

print("Ejemplo narcisista y bisiesto")
print("1.- Bisiesto")
print("2.- Narcisista")
print("3.- Años bisiestos año nacimiento")
print("Seleccione una opción")
print("---------------------")
opcion = int(input())
if (opcion == 1):
    print("Introduzca un año")
    anyo = int(input())
    respuesta = python27metodosnarcistas.isBisiesto(anyo)
    if (respuesta == True):
        print("El año es bisiesto")
    else:
        print("Año NO bisiesto")
elif (opcion == 2):
    print("Introduce un número")
    textoNumero = input()
    respuesta = python27metodosnarcistas.isNarcisista(textoNumero)
    if (respuesta == True):
        print("Es un número narcisista")
    else:
        print("Lo siento, su número NO es narcisista")
elif (opcion == 3):
    print("Introduce Año de nacimiento")
    anyoNacimiento = int(input())
    # Vamos a capturar la fecha actual (hoy)
    fechaActual = datetime.date.today()
    # Necesitamos extraer el año de la fecha actual
    anyoActual = int(fechaActual.year)
    print(anyoActual)
    for i in range(anyoNacimiento, anyoActual + 1):
        if (python27metodosnarcistas.isBisiesto(i)):
            print(i)
else:
    print("Opción incorrecta")
print("Pulse una tecla para cerrar...")
input()
print("Fin de programa")
