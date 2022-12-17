import json

print("Leer documento JSON diccionarios")
file = open("jugadores_nokey.json", "r")

# PARA TRANSFORMAR LOS DATOS JSON EN FORMATO 
# DICCIONARIO SE UTILIZA EL METODO load()
data = json.load(file);
for jugador in data:
    print(jugador["nombre"])
file.close()
# PONGAMOS QUE DESEAMOS AÑADIR NUEVOS ELEMENTOS A NUESTRO
# DICCIONARIO
#{"numero": 4, "nombre": "Gravesen"
# , "posicion": "La Gravesinha", "edad": 29
# , "imagen":}
# PARA CREAR NUEVOS OBJETOS SE UTILIZA EL METODO 
# APPEND
# UN OBJETO DICCIONARIO SE CREA MEDIANTE LLAVES
newPlayer = {
    "numero": 69,
    "nombre": "Error Garcia",
    "posicion": "Defensa de nada",
    "edad": 21,
    "imagen": ""
}
# AÑADIMOS A LA COLECCION DE DICCIONARIO UN NUEVO ELEMENTO
data.append(newPlayer)
# UNA VEZ QUE TENEMOS LOS DATOS EN data
# DEBEMOS VOLVER A ESCRIBIRLOS EN EL ARCHIVO
# EN FORMATO JSON STRING
# DEBEMOS CONVERTIR LA COLECCION DICCIONARIO EN STRING
jsonString = json.dumps(data)
# ABRIMOS EL FICHERO EN MODO ESCRITURA
file = open("jugadores_nokey.json", "w+")
file.write(jsonString)
file.flush()
file.close()
print("Fin de programa")