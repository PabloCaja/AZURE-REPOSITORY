print("Ejemplo Bucles")
print("For: ")
print("----------------")
# Normalmente las variables contador de los bucles
# se suelen expresar con una sola letra: i, z, x, j
for i in range(6):
    print("Valor de i " + str(i))
print("----------------")
print("While")
# Necesitamos una variable para la condición del bucle
contador = 0
while (contador <= 5):
    print("Contador " + str(contador))
    if (contador == 3):
        # Salimos del bucle
        break
    # Debemos hacer algo para salir del bucle
    # En este ejemplo, incrementar el contador
    contador += 1
    #contador = contador + 1
print("Fin de programa")