#Day 4 Notes
#Maxwell Floyd 9/23/19

#This program uses a loop to display a table of numbers and their squares



# Print the numbers and their squares
#  for variable in [value1, value2, etc.]
#       Statement
#       Statement
#       1. Must separate values with commas.
#       2. List - Comma separated sequence of data items
#       3. Assigns each value in the list, 1 per trip through the loop
#
#Doesnt have to be sequential Numbers
#for num in [1,2,3,4,5]:
#     print(num)
#  **Iterates 5 times
#
#
#for name in ['winken', 'blinken', 'nod']:
   #print(name)
#
#   Can use a range function
#for num in range(5):
    #print(num)
#   **Executes loop 4 times with values 0 - 4,
#     Adds 1 to num for each iteration
#
#for num in range(1,5):
    #print(num)
#   **Executes loop 4 times with values 1 - 4,
#     Adds 1 to num for each iteration
#
#for num in range(1,15,3):
    #print(num)
#      **Executes loop 5 times with values of 1, 4, 7, 10 , 13
#
#for num in range(5,0,-1):
#    print(num)
#   **Executes loop 5 times with values of 5 - 1

#get the ending limit
print('This program displays a list of numbers')
print('(starting at 1) and their squares.')
end = int(input('How high should I go? '))
totAmt = 0
#Print the Table Headings
print()
print('Number\tSquare')
print('----------------')

for number in range(1, end + 1):
    square = number**2
    totAmt += square
    print(number, '\t', format(square, '10,d'))
print ("total:", '\t', format(totAmt, '10,d'))