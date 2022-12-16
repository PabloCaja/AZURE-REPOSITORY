from conexion46doctores import ConexionDoctores
from class46doctor import Doctor

print("Main Doctores SQL Server")
connection = ConexionDoctores()
print("1.- Insertar doctor")
print("2.- Eliminar doctor")
print("3.- Buscar doctores")
print("4.- Modificar salario doctor")
print("5.- Mostrar todos los doctores")
print("Seleccione una opción")
opcion = int(input())
if (opcion == 1):
    print("Introduzca ID Doctor")
    iddoctor = int(input())
    print("Introduzca ID hospital")
    idhospital = int(input())
    print("Introduzca apellido")
    apellido = input()
    print("Introduzca especialidad")
    espe = input()
    print("Introduzca salario")
    salario = int(input())
    respuesta = connection.insertarDoctor(iddoctor, idhospital, apellido, espe, salario)
    print("Registro insertado: " + str(respuesta))
elif (opcion == 2):
    print("Introduzca ID doctor a eliminar")
    iddoctor = int(input())
    respuesta = connection.eliminarDoctor(iddoctor)
    print("Doctores eliminados " + str(respuesta))
elif (opcion == 3):
    print("Introduzca especialidad")
    espe = input()
    doctores = connection.getDoctoresEspecialidad(espe)
    for doc in doctores:
        print(doc.apellido + ", " + doc.especialidad + ", " + str(doc.salario))
elif (opcion == 4):
    print("Introduzca ID doctor")
    iddoctor = int(input())
    print("Incremento salarial")
    incremento = int(input())
    respuesta = connection.incrementarSalarioDoctor(iddoctor, incremento)
    print("Doctores modificados: " + str(respuesta))
elif (opcion == 5):
    doctores = connection.getDoctores()
    for doc in doctores:
        print(str(doc.idDoctor) + " - " + doc.apellido + " - " + doc.especialidad + " - " + str(doc.salario))
else:
    print("Opción incorrecta")
print("Fin de programa")