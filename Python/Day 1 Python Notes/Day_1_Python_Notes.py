#This is a Comment. Use the hashtag symbol to create a comment.
#Triple quotes can print text on 2 lines of code.
#When Printing multiple quotes in one print line, you can use sep='any character' to replace the spaces with the sep variable.
#Using end='any character' will replace a line break with the associated text.
#   \n  Next Line
#   \t  Tab
#   \'  Prints Apostrophe
#   \"  Prints Double Quotes
#   \\  Prints Backslash Character
print ("Hello world!")
print ("One","Two", sep='123')
print ("Mon\tTues\tWed")
print ('Enter the amount of ' + \
	'sales for each day and press enter.')

format(12345.6789, ',.2f')

#  , Insert Comma seperates
# .2 is the Precision

annual_pay = 12345.6789
print('Your annual pay is $', format(annual_pay, ',.2f'),sep=' ')

print(format(0.5, '%'))

print(format(0.5, '.0%'))

print(format(123456, 'd'))
print(format(123456, '10d'))
print(format(123456, '10,d'))

#Variables
# a-z, A-Z, 0-9, underscore
# grossPay
# TAX_RATE = .04

#Data Types
# int - Math - Whole Number
# float - Decimals with Math
# str - String

iLastName = input('What is your last name ')
print("Your name is", iLastName)

iHours = float(input("How many hours did you work?"))
cGrossPay = iHours * 17.43
print(cGrossPay)

#   +, -. *
#   /  - gives answer as float
#   // - gives answer as int
#   %, ** modulus and exponents  2**4 = 16