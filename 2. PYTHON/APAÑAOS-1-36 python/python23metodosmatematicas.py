def menuMatematicas():
    print("0.- Salir")
    print("1.- Sumar")
    print("2.- Restar")
    print("3.- Dividir")
    print("4.- Multiplicar")
    print("Seleccione una opción")
    print("------------------------")

def sumarNumeros(num1, num2):
    return num1 + num2

def restarNumeros(num1, num2):
    return num1 - num2

def dividirNumeros(num1, num2):
    return num1 / num2

def multiplicarNumeros(num1, num2):
    return num1 * num2

print("Ejemplo mates con métodos")
print("Introduzca un número 1:")
numero1 = int(input())
print("Introduzca número 2:")
numero2 = int(input())
menuMatematicas()
opcion = int(input())
if (opcion == 1):
    # Sumar
    resultado = sumarNumeros(numero1, numero2)
    print("La suma es " + str(resultado))
elif (opcion == 2):
    # Restar
    resultado = restarNumeros(numero1, numero2)
    print("La resta es " + str(resultado))
elif (opcion == 3):
    # Dividir
    resultado = dividirNumeros(numero1, numero2)
    print("La división es " + str(resultado))
elif (opcion == 4):
    # Multiplicar
    resultado = multiplicarNumeros(numero1, numero2)
    print("La multiplicación es " + str(resultado))
else:
    print("Opcion incorrecta")

print("Fin de programa")

