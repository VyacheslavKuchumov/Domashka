string = input("Введите строку:")
ostep = int(input("Введите количество символов в новых строках:"))
step = ostep
count = 1
RUN =True

rs = len(string) // step

while(RUN):
    count += 1
    string = string[:step] + ' ' + string[step:]
    step = step + ostep + 1

    if step > len(string):
        RUN = False
string = string.split()
for i in string:
    print(i)
