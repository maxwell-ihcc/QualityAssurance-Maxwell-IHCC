#Maxwell Floyd
#Logic Class Gabriel Wurtz Logic Assignment
#10/7/19

#variable Declariton
iYears = 0
cMonths = 0
cYears = 0
iInches = 0.0
cAvg = 0.0
cTotal = 0.0
oMonths = ""
oTotal = ""
oAvg = ""

def main():
    initialize():
    for cYears == 1 and cYears <= iYears and cYears += 1:
        for iMonths == 1 and iMonths <= cMonths and iMonths += 1:
            input():
            calcs():
        output():

def init():
    iYears(input("Enther the number of years"))

def input():
    iInches(input("Enter the number of inches this month"))

def calcs():
    cTotal += iInches

def output():
    cMonths = iYears / 12
    cAvg = cTotal / cMonths
    oMonths = print(format(cMonths, ','))
    oTotal = print(format(cTotal, '.,2f'))
    oAvg = print(format(cAvg, '.,2f'))

    print(("Months:", oMonths, "Total:", oTotal, "Average:", oAvg), sep='\t')
