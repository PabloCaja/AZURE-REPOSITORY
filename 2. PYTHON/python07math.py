print("Ejemplo librería Python")
# Sintaxis con from
from math import floor, ceil, trunc
numero1 = 20
numero2 = 3
division = numero1 / numero2
print("La división es " + str(division))
# Vamos a utilizar los métodos de la librería
varFloor = floor(division)
varCeil = ceil(division)
varTrunc = trunc(division)
print("Floor: " + str(varFloor))
print("Ceil: " + str(varCeil))
print("Trunc: " + str(varTrunc))
print("Fin de programa")