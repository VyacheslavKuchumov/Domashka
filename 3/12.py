import random

i = random.randint(1, 99)

if i == 1 or i % 10 == 1 and i != 11:
    print(f"Мне {i} год")
elif (i == 2 or i == 3 or i == 4 or i % 10 == 2 or i % 10 == 3 or i % 10 == 4) and (i != 12 and i != 13 and i != 14):
    print(f"Мне {i} года")
else:
    print(f"Мне {i} лет")
