import pyodbc
from class46doctor import Doctor

servidor = "LOCALHOST"
bbdd = "HOSPITAL"
usuario = "SA"
password = ""

class ConexionDoctores:
    def __init__(self):
        # TENDREMOS LA CADENA DE CONEXION EN ESTE METODO
        # Y CREAMOS UNA PROPIEDAD LLAMADA conexion PARA
        # UTILIZARLA EN EL RESTO DE METODOS DE LA CLASE
        connectionString = "DRIVER={ODBC Driver 17 for SQL Server}; SERVER=" + servidor + "; DATABASE=" + bbdd + "; UID=" + usuario + "; PWD=" + password
        # CREAMOS UNA PROPIEDAD LLAMADA conexion
        self.conexion = pyodbc.connect(connectionString)
    
    def insertarDoctor(self, iddoctor, idhospital, apellido, espe, salario):
        cursor = self.conexion.cursor()
        sql = "INSERT INTO DOCTOR VALUES (?,?,?,?,?)"
        cursor.execute(sql, (idhospital, iddoctor, apellido, espe, salario))
        registros = cursor.rowcount
        cursor.commit()
        cursor.close()
        return registros
    
    def eliminarDoctor(self, iddoctor):
        cursor = self.conexion.cursor()
        sql = "DELETE FROM DOCTOR WHERE DOCTOR_NO=?"
        cursor.execute(sql, (iddoctor))
        registros = cursor.rowcount
        cursor.commit()
        cursor.close()
        return registros
    
    def incrementarSalarioDoctor(self, iddoctor, incremento):
        cursor = self.conexion.cursor()
        sql = "UPDATE DOCTOR SET SALARIO = SALARIO + ? WHERE DOCTOR_NO=?"
        cursor.execute(sql, (incremento, iddoctor))
        registros = cursor.rowcount
        cursor.commit()
        cursor.close()
        return registros

    def getDoctores(self):
        cursor = self.conexion.cursor()
        sql = "SELECT * FROM DOCTOR"
        cursor.execute(sql)
        doctores = []
        for row in cursor:
            doctor = Doctor()
            doctor.idDoctor = row.DOCTOR_NO
            doctor.idHospital = row.HOSPITAL_COD
            doctor.apellido = row.APELLIDO
            doctor.especialidad = row.ESPECIALIDAD
            doctor.salario = row.SALARIO
            doctores.append(doctor)
        cursor.close()
        return doctores
    
    def getDoctoresEspecialidad(self, especialidad):
        cursor = self.conexion.cursor()
        sql = "SELECT * FROM DOCTOR WHERE ESPECIALIDAD = ?"
        cursor.execute(sql, (especialidad))
        doctores = []
        for row in cursor:
            doctor = Doctor()
            doctor.idDoctor = row.DOCTOR_NO
            doctor.idHospital = row.HOSPITAL_COD
            doctor.apellido = row.APELLIDO
            doctor.especialidad = row.ESPECIALIDAD
            doctor.salario = row.SALARIO
            doctores.append(doctor)
        cursor.close()
        return doctores
