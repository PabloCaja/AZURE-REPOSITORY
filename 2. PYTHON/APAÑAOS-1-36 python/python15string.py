print("Métodos clase String")
texto = "primero python"
# Vamos a ir escribiendo los métodos y viendo lo 
# que devuelven
print("Upper: " + texto.upper())
print("Replace 0-@: " + texto.replace("o", "@"))
print("texto[0]: " + texto[0])
print("Longitud len(): " + str(len(texto)))
print("find letra P: " + str(texto.find("P")))
print("find letra p " + str(texto.find("p")))
# Sobrecarga (Polimorfismo) find
print("find sobrecarga p, desde posicion 1: " + str(texto.find("p", 1)))
# las posiciones (indices) no cambiar, solamente cambia si buscamos
# desde el inicio del texto o del final
print("rfind buscar letra p: " + str(texto.rfind("p")))
print("startswith A: " + str(texto.startswith("A")))
print("endswith n: " + str(texto.endswith("n")))
print("isdigit(): " + str(texto.isdigit()))
print("isalpha(): " + str(texto.isalpha()))
print("isalnum(): " + str(texto.isalnum()))
# Vamos a ver Slicing, substring
# Queremos mostrar de la posición 2 en adelante
subcadena = texto[2:]
print("Posición 2 en adelante: " + subcadena)
# Queremos desde una posición hasta otra posición
subcadena = texto[2:5]
print("Posición [2:5]: " + subcadena)
# Vamos a recorrer todos los caracteres de la cadena uno a uno
longitud = len(texto)
for i in range(longitud):
    # capturamos cada letra
    letra = texto[i]
    print(str(i) + ": " + letra)
# Si deseamos pedir un número al usuario y saber si es un numero o no?
# El truco está en almacenar en una variable string el valor
# que nos ha dado el usuario
print("Introduzca un número")
aux = input()
if (aux.isdigit()):
    print("Es un número")
else:
    print("NO ME HAS DADO UN NUMERO!!!!")
print("Fin de programa")
