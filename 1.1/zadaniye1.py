import math

x = int(input('Введите x:'))

if x < 1:
    print('!!!ОШИБКА!!!')
   
else:
    x = math.sin(math.sqrt(x+1)) - math.sin(math.sqrt(x-1))
    print(x)
