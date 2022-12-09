from math import pow

def isBisiesto(anyo):
    if (anyo % 4 == 0):
        if (anyo % 100 != 0 or anyo % 400 == 0):
            return True
    else:
        return False

def isNarcisista(textoNumero):
    longitud = len(textoNumero)
    suma = 0
    for i in range(longitud):
        caracter = textoNumero[i]
        numero = int(caracter)
        potencia = pow(numero, longitud)
        suma = suma + potencia
    if (suma == int(textoNumero)):
        return True
    else:
        return False