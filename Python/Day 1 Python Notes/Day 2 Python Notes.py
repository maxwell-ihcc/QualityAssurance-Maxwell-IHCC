# Decision making demonstration
# Maxwell Floyd
# 9/4/19

print ("This program will show some Decision Making")

# Relational Operators 
#  >   <   >=   <=   ==   !=

minSalary = 30000
minYears = 2

Salary = float(input("What is your annual salary"))
Years = float(input("Enter your years of work"))

# Put a Colon(:) at the end of every if statement line.

if Salary >= minSalary:
    if Years >= minYears:
        print("You qualify for a loan!")
    else:
        print("You must be employed ", minYears, " years")
else:
    print("You must make at least $", format(minSalary, ',.2f'), " to qualify.")

# This is the case structure for Python

iCable = 2
if iCable == 0:
    print("No cable")
elif iCable == 1:
    print("Some cable")
else:
    print("Cheap cable")

# Logical Operators
#  Not  And  Or

if Salary <= minSalary or Years <= minYears:
    print("\n\nLoan ineligible")

hungry = True
sleepy = False