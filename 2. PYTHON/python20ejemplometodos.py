# AL INICIO INCLUIMOS TODOS LOS METODOS
def ejemploMetodo1(suma):
    print(f"Soy el método 1{suma}")
    
# Tambien podemos llamar desde un método 
# a otro método
def ejemploMetodo2():
    print("Soy el método 2")
    ejemploMetodo3()
    suma = 5
    
def ejemploMetodo3():
    print("Soy el método 3")


#CODIGO PRINCIPAL DE NUESTRO PROGRAMA
print("Ejemplo de métodos")
print("Programa principal")
# Podemos llamar a métodos ahora mediante
# condicionales
numero = 1
if (numero == 1):
    ejemploMetodo1(2)
else:
    ejemploMetodo2()
ejemploMetodo3()
print("Fin de programa")