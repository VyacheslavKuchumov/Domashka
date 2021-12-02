import random
import math

# bruh
count = 0
maximum = 0
spisok = []

a = random.randint(-100, 100)
b = random.randint(-5, 5)
c = random.randint(-100, 100)
end = random.randint(3,20)

for n in range(1,end+1):
    x = a * (n**b) + c
    spisok.append(x)
print(f"Последовательность: {spisok}")
for i in range(len(spisok)):
    if spisok[i]>=0:
        count +=1
    if count > maximum:
        maximum = count
    if spisok[i]<0:
        count = 0

print(f"Максимальное количество положительных подряд идущих чисел: {maximum}")
