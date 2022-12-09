from class34coche import Coche

# REALIZAMOS LA HERENCIA
class Deportivo (Coche):
    def turbo(self):
        self.velocidad += 80
        print("Activando turbo!!!! " + str(self.velocidad))

    def acelerar(self):
        self.velocidad += 60
        print("Velocidad actual de " + self.marca + ": " + str(self.velocidad))
