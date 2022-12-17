print("Validacion email")
print("Introduzca Email válido")
email = input()
# Contenga una @
if (email.find("@") == -1):
    print("No existe @")
elif (email.find(".") == -1):
    print("No existe punto...")
# Email no comience ni con @ ni punto
elif (email[0] == "@" or email.startswith(".") or email.endswith("@") or email.endswith(".")):
    print("Email con @ o . al inicio o final")
# Email con solo una @
elif (email.count("@") > 1):
    print("Existe más de una @")
# Exista un punto despues de la @
# paco@gmail.com  @ = 5 . = 2
elif (email.find("@") > email.rfind(".")):
    print("Necesitamos un punto despues de @")
else:
    # El dominio debe ser de dos a 4 caracteres
    # pa.co@gmail.com
    ultimoPunto = email.rfind(".")
    # Cortamos la cadena DESDE el ultimo punto en adelante
    dominio = email[ultimoPunto + 1:]
    longitudDominio = len(dominio)
    if (longitudDominio >= 2 and longitudDominio <= 4):
        print ("Email CORRECTO!!!!")
    else:
        print("El dominio debe ser entre 2 y 4 caracteres")
print ("Fin de programa")

