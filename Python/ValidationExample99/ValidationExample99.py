#Example of how to validate and update lists
#
#Maxwell Floyd
#10/23/19
#

def main():
    courseNameList = inputData()

    #create Credits List
    courseCreditsList = [0,0,0]

    courseCreditsList = validate(courseCreditsList)

    displayOutput(courseNameList, courseCreditsList)

def displayOutput(courseNameList, courseCreditsList):

    print("\n\n\t\t\tCourse\t\tCredits")
    for num in range(3):
        print("\t\t\t", courseNameList[num], "\t\t", courseCreditsList[num])

def validate(courseCreditsList):
    #Create a variable that will control the loop
    playAgain = 'y'

    while playAgain == 'y' or playAgain == 'Y':
        courseId = inputId()
        courseCreditsList = inputCredits(courseId, courseCreditsList)

        #Do you have another course credit to update?
        playAgain = input("Do you want to add another course credit? y=yes, n=no ")
    print(courseCreditsList)
    return(courseCreditsList)


def inputCredits(courseId, courseCreditsList):
    #enter course credits
    courseCredits = input("Please Enter Course Credits")

    valid = False
    while not(valid):
        if courseCredits.isdigit():
            courseCreditsList[int(courseId)] = courseCredits
            valid = True
        else:
            courseCredits = input("Course Credits must be numeric. Enter course Credits. ")
    return courseCreditsList


def inputId():
    courseId = input("Please enter your course number")
    valid = False
    while not (valid):
        if courseId.isdigit():
            if int(courseId) < 0 or int(courseId) > 2:
                courseId = input("Course Number must be 0-2. Enter course number.")
            else:
                valid = True
        else:
            courseId = input("Course Number must be numeric. Enter Course Number.")
    return courseId

def inputData():
    #create an empty list
    courseNameList = []

    for num in range(3):
        courseName = input("Please enter your course name.")
        valid = False
        while not valid:
            if not courseName or courseName.isspace():
                courseName = input("Course Name Required. Please enter Course Name")
            else:
                valid = True
                courseNameList.append(courseName)
    return courseNameList
main()