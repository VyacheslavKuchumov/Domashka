otvet = None
x = int(input('Введите x:'))
if x == 0:
    print('!!!ОШИБКА!!! \n ВВЕДИТЕ ДРУГОЕ ЧИСЛО X')

else:
    y = int(input('Введите y:'))
    otvet = (1+(1/(x**2)))**x - (12 * (x**2) * y)
    print(otvet)
