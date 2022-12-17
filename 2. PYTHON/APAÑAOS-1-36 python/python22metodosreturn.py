# METODOS RETURN
def convertirMayusculas(texto):
    # Devolvemos el texto a mayusculas
    return texto.upper()

def convertirMinusculas(texto):
    return texto.lower()

def mostrarMenu():
    print("Seleccione una opción")
    print("1.- Convertir Minúsculas")
    print("2.- Convertir Mayúsculas")

# PROGRAMA PRINCIPAL
print("Métodos RETURN")
print("Introduzca un texto")
valor = input()
# METODO DE ACCION
mostrarMenu()
# CAPTURAMOS LO QUE EL USUARIO HA ESCRITO (1, 2)
opcion = int(input())
if (opcion == 1):
    valor = convertirMinusculas(valor)
    print("Minusculas: " + valor)
else:
    valor = convertirMayusculas(valor)
    print("Mayusculas: " + valor)
print("Fin de programa")