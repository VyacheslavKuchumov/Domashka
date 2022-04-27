import numpy as np
import random

n = int(input('Введите порядок матрицы: '))

matrix = np.eye(n)

for i in range(n):
    for z in range(n):
        matrix[i,z] = random.randint(-30, 30)

print(matrix)

for i in range(n):
    for z in range(n):
        if matrix[i,z] < 0:
            matrix[i,z] = 0
        elif matrix[i,z] > 0:
            matrix[i,z] = 1

print(matrix)
ml = np.tril(matrix)

print(f'Нижняя треугольная матрица: \n{ml}')
