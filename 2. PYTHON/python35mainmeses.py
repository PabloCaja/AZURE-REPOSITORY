from class35mes import Mes
import random
# Google
# QUEREMOS LOS NOMBRE DE MES
import datetime

print("Manejando la clase Mes")
# Necesitamos crear 12 meses y los almacenamos en una lista
meses = []
for i in range(1, 13):
    miMes = Mes()
    fecha = datetime.datetime(2022, i, 1)
    nombreMes = fecha.strftime("%B")
    miMes.nombre = nombreMes.upper()
    miMes.maxima = random.randint(1, 40)
    miMes.minima = random.randint(1, 40)
    meses.append(miMes)

print("Meses generados: " + str(len(meses)))
print("Pulse INTRO para continuar")
for mes in meses:
    print(mes)
print("Fin de programa")