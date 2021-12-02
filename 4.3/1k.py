import random
import math

solution = 0
epsilon = random.randint(-50, 50)
n = random.randint(0, 50)
print(f"Эпсилон равен: {epsilon}")
print(f"Кол-во членов в последовательности: {n}")


for i in range(n+1):
    num = math.factorial(i) / 3*math.pow(i, i)
    if epsilon is abs(num) or abs(num) > epsilon:
        solution += num

print(f"Ответ: {solution}")
