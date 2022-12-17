print("Salario Trabajadores")
print("Introduzca horas trabajadas")
numeroHoras = int(input())
print("Introduzca precio/hora")
precioHora = int(input())
print("Número de Kilometros recorridos")
kilometros = int(input())
# Horas Extra, Salario Base, Salario Extra
# Dieta, Salario Total, Retencion
horasExtra = 0
salarioBase = 0
salarioExtra = 0
dieta = ""
salarioTotal = 0
retencion = ""
if (numeroHoras > 36):
    #Tenemos horas extra
    horasExtra = numeroHoras - 36
    salarioBase = precioHora * 36
    salarioExtra = horasExtra * (precioHora + 2)
else:
    # No hay horas extra
    horasExtra = 0
    salarioExtra = 0
    salarioBase = numeroHoras * precioHora
# Calculamos el número de Kilometros recorridos
if (kilometros < 100):
    dieta = "DIETA LOCAL"
elif (kilometros >= 100 and kilometros <= 500):
    dieta = "DIETA NACIONAL"
else:
    dieta = "DIETA INTERNACIONAL"
# Retención se calcula con el Salario total
salarioTotal = salarioBase + salarioExtra
if (salarioTotal <= 250):
    retencion = "NO TIENE RETENCION"
elif (salarioTotal >= 251 and salarioTotal <= 800):
    retencion = "RETENCION 20%"
else:
    retencion = "RETENCION 40%"
print("Numero horas: " + str(numeroHoras))
print("Precio hora " + str(precioHora))
print("Kilometros " + str(kilometros))
print("Horas extra " + str(horasExtra))
print("Salario extra " + str(salarioExtra))
print("Salario base " + str(salarioBase))
print("Salario total " + str(salarioTotal))
print(dieta)
print(retencion)
print("Fin de programa")