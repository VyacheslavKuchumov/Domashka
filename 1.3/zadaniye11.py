a = int(input('Введите число "a":'))
b = int(input('Введите число "b":'))
c = int(input('Введите число "c":'))

if a>0 and b>0 and c>0:
    print(c**2 == a**2 + b**2)
else:
    print('Числа должны быть больше нуля')
