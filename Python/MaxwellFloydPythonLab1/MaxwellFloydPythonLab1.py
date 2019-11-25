# Item Price Receipt
iItemPrice1 = float(input("What's the price of your first item?"))
iItemPrice2 = float(input("What's the price of your second item?"))
iItemPrice3 = float(input("What's the price of your third item?"))
iItemPrice4 = float(input("What's the price of your fourth item?"))
iItemPrice5 = float(input("What's the price of your fifth item?"))
cItemPrice1 = iItemPrice1
cItemPrice2 = iItemPrice2
cItemPrice3 = iItemPrice3
cItemPrice4 = iItemPrice4
cItemPrice5 = iItemPrice5
cItemTax= .07
cItem1Tax = cItemPrice1 * cItemTax
cItem1Total = cItemPrice1 + cItem1Tax
cItem2Tax = cItemPrice2 * cItemTax
cItem2Total = cItemPrice2 + cItem2Tax
cItem3Tax = cItemPrice3 * cItemTax
cItem3Total = cItemPrice3 + cItem3Tax
cItem4Tax = cItemPrice4 * cItemTax
cItem4Total = cItemPrice4 + cItem4Tax
cItem5Tax = cItemPrice5 * cItemTax
cItem5Total = cItemPrice5 + cItem5Tax
cTotalTax = cItem1Tax + cItem2Tax + cItem3Tax + cItem4Tax + cItem5Tax
cSubTotal = cItemPrice1 + cItemPrice2 + cItemPrice3 + cItemPrice4 + cItemPrice5
cGrandTotal= cTotalTax + cSubTotal
print("Prices: $", format(cItemPrice1, ',.2f'), sep='', end='  $')
print(format(cItemPrice2, ',.2f'), end='  $')
print(format(cItemPrice3, ',.2f'), end='  $')
print(format(cItemPrice4, ',.2f'), end='  $')
print(format(cItemPrice5, ',.2f'), end='\n')
print("Subtotal: $", format(cSubTotal, ',.2f'), sep='', end='  ')
print("Tax: $", format(cTotalTax, ',.2f'), sep='', end='  ')
print("Grand Total: $", format(cGrandTotal, ',.2f'))

# Male to Female Percentage
iMales = int(input("How many men are in the class?"))
iFemales = int(input("How many women are in the class?"))
cTotalStudents = iMales + iFemales
cMalePercent = iMales / cTotalStudents
cFemalePercent = iFemales / cTotalStudents
print("Male: ", format(cMalePercent, '.0%'), end='\t')
print("Female: ", format(cFemalePercent, '.0%'))

# Male to Female Percentage Adjusted
iAdjMales = int(input("How many men are in the class?"))
iAdjFemales = int(input("How many women are in the class?"))
cAdjTotalStudents = iAdjMales + iAdjFemales
cAdjMalePercent = iAdjMales / cAdjTotalStudents
cAdjFemalePercent = iAdjFemales / cAdjTotalStudents
print("Male: ", format(cAdjMalePercent, '.1%'), end='\t')
print("Female: ", format(cAdjFemalePercent, '.1%'))