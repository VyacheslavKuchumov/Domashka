text = input('Введите текст: ').lower()

#text = 'Раз ДВА три работа танец товарищ'.lower() ###для проверки###
count = 0
RUN = True

while(RUN):
    c = input('Введите букву: ').lower()

    for i in range(len(text)):
        if i == 0:
            if text[i] == c:
                count+=1

        else:
            if text[i] == c and text[i-1] == ' ':
                count +=1

    print(f"Количество слов, начинающихся с указанной буквы: {count}")
    prompt = input('Чтобы выйти пропишите \"quit\"\n').lower()
    count = 0
    if prompt == 'quit':
        RUN =False
