print("Validar ISBN")
print("Introduce un ISBN correcto")
isbn = input()
longitud = len(isbn)
if (isbn.isdigit() == False):
    print("Debe introducir solo números")
elif (longitud != 10):
    print("El número ISBN debe tener 10 caracteres")
else:
    suma = 0
    for i in range(longitud):
        letra = isbn[i]
        numero = int(letra)
        # La variable i comienza en 0 y nosotros
        # necesitamos multiplicar por su posición real
        posicion = i + 1
        operacion = numero * posicion
        suma = suma + operacion
    if (suma % 11 == 0):
        print("Número ISBN CORRECTO")
    else:
        print("Número ISBN incorrecto!!!!")
print("Fin de programa")