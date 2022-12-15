# METODOS CON PARAMETROS
def saludo(nombre):
    print("Bienvenido Mr/Mrs " + nombre)

def despedida(nombre, dia):
    print("Ha sido un placer hoy es dia " + dia + ", Mr/Mrs " + nombre)

# PROGRAMA PRINCIPAL
print("Ejemplo métodos con parámetros")
print("Introduce tu nombre")
name = input()
print("Introduce el día de hoy")
day = input()
# En la llamada, enviamos un valor

# QUEREMOS EL NOMBRE EN MAYUSCULAS
# LLAMAMOS AL METODO Y ALMACENAMOS EL VALOR
# QUE DEVUELVE
name = name.upper()

saludo(name)
despedida(name, day)


print("Fin de programa")