stroka = list(input("Введите строку:"))
count = 0

for i in range(len(stroka)-1, -1, -1):
    if stroka[i] == ':':
        stroka[i] = ';'
        count+=1


print(''.join(stroka))
print(f'Количество выполненных замен:{count}')
