print("Sumar caracteres numéricos")
print("Introduzca un texto con SOLO números")
aux = input()
while (aux.isdigit() == False):
    print("Que pongas SOLO números:")
    aux = input()
# Si ha puesto solo números, llegará a esta línea
# Debemos recorrer la longitud de caracteres del texto
longitud = len(aux)
# Declaramos una variable SUMA fuera del bucle, 
# ya que necesitamos ir incrementando su valor dentro
# del bucle
suma = 0
for i in range(longitud):
    # Vamos a capturar cada caracter y luego 
    # convertirlo a numero.
    # Declaramos dichas variables dentro del bucle
    # porque solamente las vamos a utilizar ahí
    # Recuperamos cada posición de cada letra
    caracter = aux[i]
    # Convertimos cada caracter a numero
    numero = int(caracter)
    suma = suma + numero
print("La suma de " + aux + " es " + str(suma))
print("Fin de programa")