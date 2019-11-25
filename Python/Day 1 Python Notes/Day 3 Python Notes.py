#RNG or Random Number Generator in Python
#Maxwell Floyd 9/9/2019

import random

def main():
    x = random.randint(1,100)
    print(x)


main()

#While loop statement Example
#Maxwell Floyd 9/11/2019

keepGoing = 'y'
while keepGoing == 'y' or keepGoing == 'Y':
    sales = float(input("Enter the amount of sales:"))
    commRate = float(input("Enter the commission rate:"))
    commission = sales * commRate
    print("The commission is $", format(commission, '10,.2f'), sep='')
    keepGoing = input('Do you want to calculate another commission (Enter y for yes)')