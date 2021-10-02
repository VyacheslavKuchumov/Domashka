n = str(input('Введите четырехзначное число:'))
if len(n) == 4:
    v1 = int(n[0])
    v2 = int(n[1])
    v3 = int(n[2])
    v4 = int(n[3])
    chet = 1
    nechet = 1
    if v1 % 2 == 0:
        chet *= v1
    else:
        nechet *= v1
    if v2 % 2 == 0:
        chet *= v2
    else:
        nechet *= v2
    if v3 % 2 == 0:
        chet *= v3
    else:
        nechet *= v3
    if v4 % 2 == 0:
        chet *= v4
    else:
        nechet *= v4
    
    print('Частное от деления произведения четных и нечетных цифр:', chet/nechet)
    
else:
    print('!!!ОШИБКА!!!\nНужно ввести ЧЕТЫРЕХЗНАЧНОЕ число')
    
