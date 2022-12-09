import json

print("Ejemplo diccionarios Python")
# LA VARIABLE data ES UN DICCIONARIO JSON
data = {
    'employees' : [
        {
            'name' : 'John Doe',
            'department' : 'Marketing',
            'place' : 'Remote'
        },
        {
            'name' : 'Jane Doe',
            'department' : 'Software Engineering',
            'place' : 'Remote'
        },
        {
            'name' : 'Don Joe',
            'department' : 'Software Engineering',
            'place' : 'Office'
        }
    ]
}

# SI DESEAMOS REALIZAR UN print DE UN DICCIONARIO
# DEBEMOS CONVERTIRLO A STRING, dumps()
jsonString = json.dumps(data)
print(jsonString)
# SI DESEAMOS RECORRER O RECUPERAR ELEMENTOS DENTRO DE DICCIONARIO
# DEBEMOS RECORRER data, YA QUE ES COMO UNA LISTA/COLECCION
for elemento in data['employees']:
    print(elemento["name"])
print("Fin de programa")