class Mes:
    nombre = ""
    maxima = 0
    minima = 0

    def getMedia(self):
        return (self.maxima + self.minima) / 2
    
    # Por comodidad y para devolver el print del objeto
    # vamos a personalizar __str__
    def __str__(self):
        return (self.nombre + ", Máxima: " + str(self.maxima) + ", Mínima: " + str(self.minima) + ", Media: " + str(self.getMedia()))


        