solution = None
class Person:
    def __init__(self, m, n, p):
        self.m = m
        self.n = n
        self.p = p

ivanov = Person(int(input('Введите количество баллов Иванова в первом туре:')),int(input('Введите количество баллов Иванова во втором туре:')) , int(input('Введите количество баллов Иванова в третьем туре:')))
petrov = Person(int(input('Введите количество баллов Петрова в первом туре:')),int(input('Введите количество баллов Петрова во втором туре:')) , int(input('Введите количество баллов Петрова в третьем туре:')))
sidorov = Person(int(input('Введите количество баллов Сидорова в первом туре:')),int(input('Введите количество баллов Сидорова во втором туре:')) , int(input('Введите количество баллов Сидорова в третьем туре:')))

ivanov = ivanov.m + ivanov.n + ivanov.p
petrov = petrov.m + petrov.n + petrov.p
sidorov = sidorov.m + sidorov.n + sidorov.p

solution = ivanov
if petrov > solution:
    solution = petrov

if sidorov > solution:
    solution = sidorov

print("Победитель набрал", solution, "баллов")
