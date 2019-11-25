iMonth = int(input("Enter a Month in numerical format"))
iDay = int(input("Enter a day in numerical format"))
iYear = int(input("Enter the last two digits of the year (i.e 20, which would be 1920 or 2020)"))
cMagic = iMonth * iDay
if iYear == cMagic:
    print("That's a Magical Date!")
else:
    print("Too bad! That's not very magical!")

#Software Sales
iNumberPurchased = int(input("How many Packages did you purchase?"))
cSubtotal = iNumberPurchased * 99
if iNumberPurchased < 10:
    cDiscount = 0
elif iNumberPurchased >= 10 and iNumberPurchased <= 19:
    cDiscount = 0.10
elif iNumberPurchased >= 20 and iNumberPurchased <= 49:
    cDiscount = 0.20
elif iNumberPurchased >= 50 and iNumberPurchased <= 99:
    cDiscount = 0.30
elif iNumberPurchased > 99:
    cDiscount = 0.40
cTotalDiscount = cSubtotal * cDiscount
cGrandTotal = cSubtotal - cTotalDiscount
print("Discount: ", format(cDiscount, '.0%'), end='\t')
print("Subtotal: $", format(cSubtotal, ',.2f'), end= '\t')
print("Grand Total: $", format(cGrandTotal, ',.2f'))