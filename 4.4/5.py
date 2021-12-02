import random
import math

# Шаг функции
h = 1

a = random.randint(-100, 100)
b = random.randint(a+1, a+101)

print(f"Функция на промешутке: ({a},{b})")
for x in range(a, b+1, h):
    y = math.atan(x)+1
    print(f"x = {x}")
    print(f"y = {y}")
