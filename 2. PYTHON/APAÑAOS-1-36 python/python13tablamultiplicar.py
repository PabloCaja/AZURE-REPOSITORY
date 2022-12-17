print("Tabla de multiplicar")
print("Introduzca un número")
numero = int(input())
for i in range(1, 11):
    # Realizamos las operaciones
    multiplicacion = numero * i
    print(str(numero) + " * " + str(i) + " = " + str(multiplicacion))
print("Fin del bucle")