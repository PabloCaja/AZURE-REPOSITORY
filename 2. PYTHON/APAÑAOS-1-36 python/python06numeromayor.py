print("Programa numero mayor")
print("Introduzca numero 1")
numero1 = int(input())
print("Introduzca numero 2")
numero2 = int(input())
if (numero1 > numero2):
    print("El numero mayor es " + str(numero1))
elif (numero1 == numero2):
    print("Los dos numeros son iguales")
else:
    print("El numero mayor es " + str(numero2))
print("Fin de programa")