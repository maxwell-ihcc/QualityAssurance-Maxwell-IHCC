#Example of how to validate fields

info = [ "Max", 11, 12.4,]
nameList = []
def validateEntry(courseName):

    if not courseName or courseName.isspace():
        print('Invalid')
    else:
        print(courseName)
    return courseName

    #validData = courseName.isspace()
    #print(validData)

def inputData():
    courseName = input("Please enter your course name")
    return courseName

def main():
    for x in range(0,13):
        courseName = inputData()
        nameList[x] = validateEntry(courseName)
print(nameList)
main();
