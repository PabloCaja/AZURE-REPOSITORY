from math import trunc
print("Calcular dia semana")
print("Introduzca día")
dia = int(input())
print("Introduzca mes")
mes = int(input())
print("Introduzca año")
anyo = int(input())
# Normalmente, las variable se declaran al principio
# de un programa
op1 = 0
op2 = 0
op3 = 0
op4 = 0
op5 = 0
op6 = 0
resultado = 0
if (mes == 1):
    mes = 13
    anyo = anyo - 1
elif (mes == 2):
    mes = 14
    anyo = anyo - 1
op1 = trunc((mes + 1) * 3 / 5)
op2 = trunc(anyo / 4)
op3 = trunc(anyo / 100)
op4 = trunc(anyo / 400)
op5 = trunc(dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2)
op6 = trunc(op5 / 7)
resultado = trunc(op5 - (op6 * 7))
if (resultado == 0):
    print("SABADO")
elif (resultado == 1):
    print("DOMINGO")
elif (resultado == 2):
    print("LUNES")
elif (resultado == 3):
    print("MARTES")
elif (resultado == 4):
    print("MIERCOLES")
elif (resultado == 5):
    print("JUEVES")
elif (resultado == 6):
    print("VIERNES")

print("Fin de programa")    