#Maxwell Floyd
#Paint Job Estimator Lab #5
#10/9/19
HourlyCharge = 35.00
PaintSpace = float(input("How much wall space will be painted in square feet? "))
PaintPrice = float(input("How much does your paint cost per gallon? "))
Hours = PaintSpace / 14
PaintNeeded = PaintSpace / 112
TotalPaintPrice = PaintNeeded * PaintPrice
TotalHourPrice = Hours * HourlyCharge
GrandTotal = TotalPaintPrice + TotalHourPrice
print("\n")
print("\n")
print("Gallons Required: ", format(PaintNeeded, ',.2f'), end= '\n')
print("Hours of Labor Required: ", format(Hours, ',.1f'), end= '\n')
print("Paint Cost: $", format(TotalPaintPrice, ',.2f'), end= '\n')
print("Cost of Labor: $", format(TotalHourPrice, ',.2f'), end= '\n')
print("Grand Total: $", format(GrandTotal, ',.2f'), end= '\n')
print("Have an amazing day!")