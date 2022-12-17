# IMPORTAMOS LA CLASE PERSONA PARA TRABAJAR CON ELLA
from class33persona import Persona

print("Ejemplo clases persona")
# INSTANCIAMOS UN OBJETO DE LA CLASE PERSONA
person = Persona()
# Podemos cambiar la propiedad una vez creado el objeto
person.pais = "España"
print("Pais: " + person.pais)
# INCLUIMOS DATOS PARA LA PERSONA
person.nombre = "Alumno"
person.apellidos = "Python"
person.email = "alumnopython@gmail.com"
person.anyonacimiento = 2001
# LLAMAMOS A LOS METODOS
print(person.getNombreCompleto())
print("Edad: " + str(person.getEdad()))
print(person)
print(person.getDescripcion("Rubia ojos verdes"))
# CREAMOS OTRO OBJETO Y LO VAMOS TAMBIEN
person2 = Persona()
print("Pais persona 2 " + person2.pais)
print("Fin de programa")