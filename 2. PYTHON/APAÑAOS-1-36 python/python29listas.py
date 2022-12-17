# DECLARAMOS UNA VARIABLE CON VARIOS NOMBRES
# ESTA VARIABLE LA VAMOS A UTILIZAR EN EL PROGRAMA PRINCIPAL 
# Y TAMBIEN EN LOS METODOS
nombres = ["Adrian", "Lucia", "Carlos", "Pedro", "Diana", "Maria", "Adrian"]

def mostrarNombres():
    # Dibujamos los nombres con un bucle de Referencia
    # for name in nombres:
    #     print(name)
    # Lo hacemos con un bucle contador porque quiero visualizar
    # las posiciones de cada nombre
    for i in range(len(nombres)):
        name = nombres[i]
        print(str(i) + ".- " + name)

print("Ejemplo de listas Python")
# AÑADIMOS UN NUEVO NOMBRE
# nombres.append("El nuevo")
# INSERTAMOS UN ELEMENTO EN EL MEDIO
# nombres.insert(1, "El del medio")
# Eliminamos utilizando REMOVE
# nombres.remove("Adrian")
# Eliminamos utilizando INDICE
# nombres.pop(6)
# mostrarNombres()
print("Lista de números enteros")
numeros = [20,4,14,55,52,66,99,12]
# Orden Ascendente
# numeros.sort()
# Orden Descendente
numeros.sort( reverse = True )
for num in numeros:
    print(num)
print("Fin de programa")
