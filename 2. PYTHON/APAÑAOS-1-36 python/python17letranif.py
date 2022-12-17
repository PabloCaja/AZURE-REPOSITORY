from math import trunc
print("Calcular letra NIF")
print("Introduzca número DNI")
aux = input()
if (aux.isdigit() == False):
    print("Debe introducir solamente NUMEROS")
elif (len(aux) != 8):
    print("El NIF debe contener 8 caracteres")
else:
    numeroDni = int(aux);
    resultado = ((numeroDni - (trunc(numeroDni / 23) * 23)))
    solucionCaracteres = "TRWAGMYFPDXBNJZSQVHLCKET"
    letraDni = solucionCaracteres[resultado]
    print("Su letra de NIF es: " + letraDni)
print("Fin de programa")