print("Ejemplo ficheros Python")
# Creamos un nuevo archivo y escribimos algo en él.
# Voy a utilizar w+ Lectura/Escritura
fichero = open("nombre.txt","w+")
print("Introduzca su nombre")
nombre = input()
# Escribimos en el archivo
fichero.write("Su nombre es " + nombre)
# Es recomendable/obligatorio utilizar FLUSH
fichero.flush()
# Siempre cerramos el archivo para todas las acciones
fichero.close()
# A continuación, añadimos información al archivo
# creado
# Abrimos el archivo en modo append (a)
archivo = open("nombre.txt", "a")
print("Introduzca otro nombre")
nombre = input()
archivo.write("\n Nuevo nombre: " + nombre)
archivo.flush()
archivo.close()
# Por último, leemos el contenido de lo que hemos
# almacenado en el fichero
file = open("nombre.txt", "r")
contenido = file.read()
print("-------------------------")
print(contenido)
file.close()
print("Fin de programa")