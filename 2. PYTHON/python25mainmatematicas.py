# IMPORTAMOS LOS METODOS DE LA CLASE PYTHON24
from python24funcionesmatematicas import *

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