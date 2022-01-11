string = input()
count = 0
otvet = []

for c in string:
    for c1 in string:
        if c == c1:
            count += 1
    if count == 1:
        otvet.append(c)
    count = 0
print(otvet)
