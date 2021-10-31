def F(x):
    if x <3.2:
        return((x**4) + 9)
    else:
        return((54*(x**4)) / (-5*(x**2)+7))

print("Ответ:",F(float(input("Введите x:"))))
