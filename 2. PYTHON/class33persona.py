class Persona:
    nombre = ""
    apellidos = ""
    email = ""
    anyonacimiento = 0
    pais = "Lo que sea..."

    # El constructor es un método para iniciar
    # los valores de las propiedades de la clase
    # Por ejemplo, pongamos que queremos que cualquier
    # persona, al crearla sea de una Pais: FRANCIA
    def __init__(self):
        self.pais = "Francia"
    
    # METODO PARA PERSONALIZAR EL DIBUJO DE LA CLASE
    def __str__(self):
        return self.apellidos + " " + self.nombre + ", Pais: " + self.pais

    # METODO PARA RECUPERAR LOS DATOS COMPLETOS DE UNA PERSONA
    def getNombreCompleto(self):
        return self.nombre + " " + self.apellidos

    # METODO PARA QUE NOS DEVUELVA LA EDAD
    def getEdad(self):
        return 2022 - self.anyonacimiento

    def getDescripcion(self, descripcion):
        return self.getNombreCompleto() + ", " + descripcion
