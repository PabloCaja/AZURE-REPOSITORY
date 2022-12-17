from class34coche import Coche
from class34deportivo import Deportivo

print("Conduciendo mi deportivo")
car = Deportivo()
car.marca = "Ferrari"
car.modelo = "Testarossa"
opcion = -1
while (opcion != 0):
    print("------------------")
    print("0.- Salir")
    print("1.- Arrancar")
    print("2.- Acelerar")
    print("3.- Frenar")
    print("4.- Detener coche")
    print("5.- Turbo")
    print("Seleccione una opción")
    opcion = int(input())
    if (opcion == 1):
        car.arrancar()
    elif (opcion == 2):
        car.acelerar()
    elif (opcion == 3):
        car.frenar()
    elif (opcion == 4):
        car.detener()
    elif (opcion == 5):
        car.turbo()
    elif (opcion == 0):
        print("Saliendo del programa")
    else:
        print("Opción incorrecta")
print("Fin de programa")