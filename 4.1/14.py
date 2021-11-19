import random

stipuha = random.randint(1000, 10000)
rashodi = random.randint(stipuha+random.randint(1, 100), stipuha+random.randint(5000, 10000))

zatarti = 0
pribil = 0

print(f"Стипендия: {stipuha}р\nРасход за первый месяц: {rashodi}р")
zatarti += rashodi
pribil += stipuha
for months in range(9):
    rashodi = rashodi + rashodi / 100 * 3
    zatarti += rashodi
    pribil += stipuha

print(f"Чтобы прожить учебный год, у родителей придется попросить: {zatarti - pribil:.2f}р")
