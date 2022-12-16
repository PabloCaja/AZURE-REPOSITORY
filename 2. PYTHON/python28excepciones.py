def mostrarDoble():
    try:
        print("Introduzca un número")
        numero = int(input())
        doble = numero * 2
        print("El doble del número es " + str(doble))
    except ValueError:
        print("Error, debe introducir un número")
    except ZeroDivisionError():
        print("La division da cero loko")    
        mostrarDoble()

def dividirNumeros():
    try:
        print("Introduzca número 1:")
        numero1 = int(input())
        print("Introduzca número 2: ")
        
        numero2 = int(input())
        division = numero1 / numero2
        print("La división es " + str(division))
    except:
        print("Error general de algún tipo...")
    finally:
        print("Siempre me ejecuto")

print("Programa principal de control de excepciones")
dividirNumeros()

# Como buena praxis, siempre debemos 
# cerrar las conexiones
try:
    print("Conectando a BBDD")
    print("Leyendo registros")
except:
    print("Error en acceso a datos")
finally:
    print("Cerrando conexión BBDD")


print("Fin de programa")