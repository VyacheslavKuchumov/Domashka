import math
import sys

class Pyramid:
    def __init__(self,AB,BC,CA,SA,SB,SC):
        self.AB = AB
        self.BC = BC
        self.CA = CA
        self.SA = SA
        self.SB = SB
        self.SC = SC

def ploshad(a,b,c):
    p = (a+b+c)/2
    if a + b < c or a + c < b or c + b < a:
         sys.exit("ТАКОЙ ПИРАМИДЫ НЕ СУЩЕСТВУЕТ")
    else:
        return math.sqrt(p*(p-a)*(p-b)*(p-c))


p1 = Pyramid(int(input("Введите длину ребра AB первой пирамиды:")), int(input("Введите длину ребра BC первой пирамиды:")), int(input("Введите длину ребра CA первой пирамиды:")), int(input("Введите длину ребра SA первой пирамиды:")), int(input("Введите длину ребра SB первой пирамиды:")), int(input("Введите длину ребра SC первой пирамиды:")))
p2 = Pyramid(int(input("Введите длину ребра AB второй пирамиды:")), int(input("Введите длину ребра BC второй пирамиды:")), int(input("Введите длину ребра CA второй пирамиды:")), int(input("Введите длину ребра SA второй пирамиды:")), int(input("Введите длину ребра SB второй пирамиды:")), int(input("Введите длину ребра SC второй пирамиды:")))

s1 = ploshad(p1.AB,p1.SB,p1.SA) + ploshad(p1.BC,p1.SC,p1.SB) + ploshad(p1.SC,p1.SA,p1.CA) + ploshad(p1.CA,p1.AB,p1.BC)
s2 = ploshad(p2.AB,p2.SB,p2.SA) + ploshad(p2.BC,p2.SC,p2.SB) + ploshad(p2.SC,p2.SA,p2.CA) + ploshad(p2.CA,p2.AB,p2.BC)

if s1 > s2:
    print('Площадь поверхности первой пирамиды больше')
else:
    print('Площадь поверхности второй пирамиды больше')
