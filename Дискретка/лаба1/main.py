def convertBase(n, toBase):

    alphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    if n < toBase:
        return alphabet[n]
    else:
        return convertBase(n // toBase, toBase) + alphabet[n % toBase]


number = int(input('Введите число: '))
base = int(input('Введите систему счисления: '))
if base >= 2 and base <=36 and number >= 0:
    print(f"Число {number} в {base} системе счисления будет: {convertBase(number, base)}")
else:
    print('Ошибка ввода')

