import random
import time


lista = list()
n = len(lista)

class Números:

    def __init__(self):
        pass

    def generarNumerosAleatorios(self):
        aleatorio = random.randint(10, 100)
        for _ in range(aleatorio):
            numeros = random.randint(0,aleatorio)
            lista.append(numeros)
        return f"Número al azar: {aleatorio}\n "\
            f"Lista aleatoria: {lista}";

    def countingSort(self,list, e):
        n = len(list)
        output = [0] * (n)
        contador = [0] * (10)
        for i in range(0, n):
            b = list[i] // e
            contador[b % 10] += 1

        for i in range(1, 10):
            contador[i] += contador[i - 1]

        i = n - 1
        while i >= 0:
            b = list[i] // e
            output[contador[b % 10] - 1] = list[i]
            contador[b % 10] -= 1
            i -= 1

        i = 0
        for i in range(0, len(list)):
            list[i] = output[i]

    def radixSort(self,list):
        maximo = max(list)
        n = len(list)

        e = 1
        while maximo / e > 0:
            self.countingSort(list, e)
            e *= 10
        return f"Lista ordenada: {lista}\n " \
               f"Números dentro de la lista: {n}"


inicio = time.time()
numero = Números()
print(numero.generarNumerosAleatorios())
print(numero.radixSort(lista))
print(f"Tiempo que tardo la ejecución: {time.time() - inicio}")