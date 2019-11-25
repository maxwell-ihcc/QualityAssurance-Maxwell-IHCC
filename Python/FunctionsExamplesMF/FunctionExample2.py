#Functions and Multiple Arguments Example
#Max Floyd
#10/2/19

def main():
    iKeepGoing = 1
    while iKeepGoing == 1:
        iAge = int(input("What is your age"))
        iFirstName = input("What is your first name?")
        iLastName = input("What is your last name?")
        #This demonstrates a call to the legal function where the arguments are assinged to the parameters
        #in the order they are listed

        #legal(iFirstName, iLastName, iAge)

        #This demonstrates a call to the legal function where the arguments are assigned
        #to keyword parameters
        legal(Age=iAge, lName=iLastName, fName=iFirstName)
        iKeepGoing = int(input("0 to exit, 1 to continue."))

def legal(fName, lName, Age):
    if Age < 21:
        print(fName, lName, "is underage")
    else:
        print(fName, lName, "is legal")

main()