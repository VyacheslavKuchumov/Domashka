import math
otvet = 0
n = int(input('Введите число n:'))

if n > 1:
    for i in range(1, n+1):
        otvet += math.factorial(i)
    print("Ответ:",otvet)
else:
    print('N должно быть больше единицы')
