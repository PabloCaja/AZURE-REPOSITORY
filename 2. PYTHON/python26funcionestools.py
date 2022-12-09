from math import trunc

def getLetraNif(aux):
    if (aux.isdigit() == False):
        return "Debe introducir solamente NUMEROS"
    elif (len(aux) != 8):
        return "El NIF debe contener 8 caracteres"
    else:
        numeroDni = int(aux);
        resultado = ((numeroDni - (trunc(numeroDni / 23) * 23)))
        solucionCaracteres = "TRWAGMYFPDXBNJZSQVHLCKET"
        letraDni = solucionCaracteres[resultado]
        return "Su letra de NIF es: " + letraDni

def validarIsbn(isbn):
    longitud = len(isbn)
    if (isbn.isdigit() == False):
        return "Debe introducir solo números"
    elif (longitud != 10):
        return "El número ISBN debe tener 10 caracteres"
    else:
        suma = 0
        for i in range(longitud):
            letra = isbn[i]
            numero = int(letra)
            # La variable i comienza en 0 y nosotros
            # necesitamos multiplicar por su posición real
            posicion = i + 1
            operacion = numero * posicion
            suma = suma + operacion
        if (suma % 11 == 0):
            return "Número ISBN CORRECTO"
        else:
            return "Número ISBN incorrecto!!!!"

def validarEmail(email):
    if (email.find("@") == -1):
        return "No existe @"
    elif (email.find(".") == -1):
        return "No existe punto..."
    # Email no comience ni con @ ni punto
    elif (email[0] == "@" or email.startswith(".") or email.endswith("@") or email.endswith(".")):
        return "Email con @ o . al inicio o final"
    # Email con solo una @
    elif (email.count("@") > 1):
        return "Existe más de una @"
    # Exista un punto despues de la @
    # paco@gmail.com  @ = 5 . = 2
    elif (email.find("@") > email.rfind(".")):
        return "Necesitamos un punto despues de @"
    else:
        # El dominio debe ser de dos a 4 caracteres
        # pa.co@gmail.com
        ultimoPunto = email.rfind(".")
        # Cortamos la cadena DESDE el ultimo punto en adelante
        dominio = email[ultimoPunto + 1:]
        longitudDominio = len(dominio)
        if (longitudDominio >= 2 and longitudDominio <= 4):
            return "Email CORRECTO!!!!"
        else:
            return "El dominio debe ser entre 2 y 4 caracteres"