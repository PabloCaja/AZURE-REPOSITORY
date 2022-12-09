from python26funcionestools import *

print("Main Tools")
print("1.- Validar Mail")
print("2.- Validar ISBN")
print("3.- Mostrar letra NIF")
print("Seleccione una opción")
print("-------------------------")
opcion = int(input())
if (opcion == 1):
    print("Introduzca un email válido")
    email = input()
    resultado = validarEmail(email)
    print(resultado)
elif (opcion == 2):
    print("Introduzca un ISBN")
    isbn = input()
    resultado = validarIsbn(isbn)
    print(resultado)
elif (opcion == 3):
    print("Introduzca su número de DNI")
    dni = input()
    resultado = getLetraNif(dni)
    print(resultado)
else:
    print("Opción incorrecta")
print("Fin de programa")