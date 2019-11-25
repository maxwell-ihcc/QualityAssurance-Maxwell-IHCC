#functions and Arguments Examples
#Max Floyd
#10/2/19

def main():
    iKeepGoing = 1
    while iKeepGoing == 1:
        iAge = int(input("What is your age?"))
        legal(iAge)
        iKeepGoing = int(input("Enter 0 to Exit, 1 to continue"))

def legal(ageCheck):
    if ageCheck < 21:
        print("Underage")
    else:
        print("Legal")

main()