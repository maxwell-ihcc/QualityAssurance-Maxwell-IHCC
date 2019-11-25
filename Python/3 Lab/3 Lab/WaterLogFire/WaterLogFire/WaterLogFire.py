# Heather Wemer
# 09/09/2019

water = 1
log = 2
fire = 3

import random

keepGoing = 'y'
while keepGoing == 'y' or keepGoing == 'Y':
    userInput = (input("Enter choice: water, log, fire: "))
    def main():
        def compInput():
            x = random.randint(1,3)

            if x == 1:
                print("Water")
            elif x == 2:
                print("Log")
            else:
                print("Fire")
        compInput()
        main():


    if userInput == water and x == 3:
        print(userInput, x, "You win!")
    elif userInput == log and x == 1:
        print(userInput, x, "You win!")
    elif userInput == fire and x == 2:
        print(userInput, x, "You win!")
    else: 
        print("You lose. :( Wah wah!")

    keepGoing = input("Do you want to play again? (Enter y for yes)")


