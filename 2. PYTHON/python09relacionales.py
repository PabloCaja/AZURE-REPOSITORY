print("Condicionales Relacionales")
print("Introduzca un número")
numero = int(input())
if (numero == 1 or numero == 2 or numero == 3 or numero == 4):
    print("El numero es 1, 2, 3 o 4")
elif (numero >=5 and numero <= 10):
    print("El número está entre 5 y 10")
elif (numero == 0 or numero < 0):
    print("El número es negativo o igual a cero")    
else:
    print("El número es mayor a 10")
print("Fin de programa")    
