import random
with open("numbers.txt", "w+") as f:
    for i in range(5):
        f.write(f'{random.randint(1, 999)} ')


with open("numbers.txt", "r") as f:
    contents = str(f.read()).split()

otvet = []

for i in contents:
    otvet.append(i[0])


with open("numbers.txt", "a") as f:
    f.write('\n')
    for n in otvet:
        f.write(n)









