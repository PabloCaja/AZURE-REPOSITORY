print("Ejemplo operaciones matematicas")
numero1 = 20
numero2 = 3
suma = numero1 + numero2
multiplicacion = numero1 * numero2
division = numero1 / numero2
resto = numero1 % numero2
print("Suma " + str(suma))
print("La multiplicacion de " + str(numero1) + " * " + str(numero2) + " es " + str(multiplicacion))
print("Division " + str(division))
print("Resto " + str(resto))
# Las conversiones solamente entre tipos compatibles
# Redondeamos la división (Trunca)
redondeo = int(division)
print("Division redondeada " + str(redondeo))
# No hace milagros, esto nos dará un error en ejecución
texto = "Martes!!!"
miNumero = int(texto)
print(miNumero)
