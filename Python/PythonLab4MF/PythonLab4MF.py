#Maxwell Floyd 9/24/19
#Python Lab 4
#Bug Collector Loop
totBugs = 0
for days in range(1, 8):
    dailyBugs= int(input("How many bugs did you collect today?"))
    totBugs = totBugs + dailyBugs
    print("Day ", days,  "Bugs: ", format(dailyBugs, ','), end='\t')
    print("Total: ", format(totBugs, ','), end='\n')
print("\n")

#Pennies For Pay Loop
pPay = 0.01
totPay= 0
pEnd = int(input("How many days are you being paid?"))
for pDays in range(1, pEnd + 1):
    pPay = pPay * 2
    totPay = totPay + pPay
    print("Day ", pDays, "Pay: $", format(pPay, ',.2f'), end="\t")
    print("Total Pay: $", format(totPay, ',.2f'), end= "\n")
    