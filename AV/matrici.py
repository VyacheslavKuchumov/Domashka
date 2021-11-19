import random
import numpy as np

m = np.array([[0, 0, 0], [0, 0, 0], [0, 0, 0]])

sumstolb1 = 0
sumstolb2 = 0
sumstolb3 = 0

osum = 0
psum = 0
otriz = 0
polozh = 0

maxim = -100
minim = 100

for i in range(3):
    for z in range(3):
        m[i, z] = random.randint(-50, 50)
        if m[i, z] >= 0:
            polozh += 1
            psum += m[i, z]
        if m[i, z] < 0:
            otriz += 1
            osum += m[i, z]
        if m[i, z] > maxim:
            maxim = m[i, z]
            imaks = i
            zmaks = z
        if m[i, z] < minim:
            minim = m[i, z]
            imin = i
            zmin = z

z = 0
while z <= 2:
    for i in range(3):
        if z == 0:
            sumstolb1 += abs(m[i, z])
        if z == 1:
            sumstolb2 += abs(m[i, z])
        if z == 2:
            sumstolb3 += abs(m[i, z])
    z += 1







print(m)
print(f'Количество положительных элементов: {polozh}')
print(f'Количество отрицательных элементов: {otriz}')
print(f'Сумма положительных элементов: {psum}')
print(f'Сумма отрицательных элементов по модулю: {abs(osum)}')
print(f'Сумма первого столбца по модулю: {sumstolb1}')
print(f'Сумма второго столбца по модулю: {sumstolb2}')
print(f'Сумма третьего столбца по модулю: {sumstolb3}')
print(f'Максимальный элемент расположен тут: {zmaks+1} столбец  {imaks+1} строка')
print(f'Минимальный элемент расположен тут: {zmin+1} столбец {imin+1} строка')

