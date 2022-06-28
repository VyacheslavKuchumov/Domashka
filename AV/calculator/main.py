from tkinter import *
import math

def doMath():
    if op.get() == "+":
        add(complex(n1.get()), complex(n2.get()))
    if op.get() == "-":
        subtract(complex(n1.get()), complex(n2.get()))
    if op.get() == "*":
        multiply(complex(n1.get()), complex(n2.get()))
    if op.get() == "/":
        devide(complex(n1.get()), complex(n2.get()))
    if op.get() == "^":
        exponent(complex(n1.get()), complex(n2.get()))


def add(num1, num2):

    answer.delete(0, END)
    answer.insert(0, complex(num1.real+num2.real, num1.imag+num2.imag))

def subtract(num1, num2):

    answer.delete(0, END)
    answer.insert(0, complex(num1.real-num2.real, num1.imag-num2.imag))

def multiply(num1, num2):
    answer.delete(0, END)
    answer.insert(0, complex(num1.real*num2.real - num1.imag*num2.imag, num1.real*num2.imag + num1.imag*num2.real))

def devide(num1, num2):
    answer.delete(0, END)
    answer.insert(0, complex((num1.real*num2.real + num1.imag*num2.imag)/(num2.real**2 + num2.imag**2), (num2.real*num1.imag - num1.real*num2.imag)/(num2.real**2 + num2.imag**2)))

def exponent(num1, num2):
    a = num1.real
    b = num1.imag
    if a > 0 and b > 0:
        fi = math.atan(b/a)
    elif a > 0 and b < 0:
        fi = -math.atan(b/a)
    elif a < 0 and b > 0:
        fi = math.pi - math.atan(b/a)
    elif a < 0 and b < 0:
        fi = -math.pi + math.atan(b / a)
    elif a == 0 and b > 0:
        fi = math.pi / 2
    elif a == 0 and b < 0:
        fi = -(math.pi / 2)
    elif a > 0 and b == 0:
        fi = 0
    elif a < 0 and b == 0:
        fi = math.pi
    z = math.sqrt((a**2) * (b**2))


    answer.delete(0, END)
    answer.insert(0, complex(num1)**num2)


root =Tk()
root.title("Calculator")
labelLeft = Label(root, text="Number")
labelRight = Label(root, text="Number")
labelCenter = Label(root, text="Operator")
labelCenter.grid(row=0, column=1, columnspan=1)
labelLeft.grid(row=0, column=0, columnspan=1)
labelRight.grid(row=0, column=2, columnspan=1)
n1 = Entry(root, borderwidth=10)
n1.grid(row=1, column=0, columnspan=1)
op = Entry(root, borderwidth=10)
op.grid(row=1, column=1, columnspan=1)
n2 = Entry(root, borderwidth=10)
n2.grid(row=1, column=2, columnspan=1)

bruh = Label(root, text="=", width=4)
bruh.grid(row=1, column=3)

answer = Entry(root, borderwidth=10, width=100)
answer.grid(row=1, column=4, columnspan=1)
aText = Label(root, text="Answer")
aText.grid(row=0, column=4)
submitBtn = Button(root, width=150, text="SUBMIT",borderwidth=10 , command=doMath)
submitBtn.grid(row=3, columnspan=5)






root.mainloop()


