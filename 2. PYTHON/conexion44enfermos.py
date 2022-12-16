import pyodbc
servidor = "LOCALHOST"
bbdd = "HOSPITAL"
usuario = "SA"
password = ""

class ConexionEnfermos:
    # EN EL INICIO DE LA CLASE DEBEMOS CREAR
    # UN OBJETO CONEXION PARA UTILIZARLO EN TODOS
    # LOS METODOS (CONSTRUCTOR)
    def __init__(self):
        # self ES LA CLASE EN LA QUE ESTAMOS TRABAJANDO
        # Y NOS VAMOS A CREAR UNA PROPIEDAD PARA 
        # TENER LA CONEXION
        connectionString = "DRIVER={ODBC Driver 17 for SQL Server}; SERVER=" + servidor + "; DATABASE=" + bbdd + "; UID=" + usuario + "; PWD=" + password
        # CREAMOS UNA PROPIEDAD LLAMADA conexion
        self.conexion = pyodbc.connect(connectionString)
    # TENDREMOS UN METODO PARA ELIMINAR UN ENFERMO
    # POR SU INSCRIPCION
    def eliminarEnfermo(self, inscripcion):
        # CREAR CURSOR, EJECUTAR Y CERRAR 
        cursor = self.conexion.cursor()
        sql = "DELETE FROM ENFERMO WHERE INSCRIPCION=?"
        cursor.execute(sql, (inscripcion))
        eliminados = cursor.rowcount
        cursor.commit()
        cursor.close()
        return eliminados
    
    def modificarEnfermo(self, apellido, inscripcion):
        # CREAR CURSOR, EJECUTAR Y CERRAR
        cursor = self.conexion.cursor()
        sql = "UPDATE ENFERMO SET APELLIDO=? WHERE INSCRIPCION=?"
        cursor.execute(sql, (apellido, inscripcion))
        modificados = cursor.rowcount
        cursor.commit()
        cursor.close()
        return modificados

