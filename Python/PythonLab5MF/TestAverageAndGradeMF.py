#Maxwell Floyd
#Test Average and Grade Lab #5
#10/9/19
def CalcAverage():
    TestSubmit = 1
    TotalScore = 0
    Average = 0
    for TestSubmit in range(1, 6):
       TestScore = float(input("Enter your Test score "))
       TotalScore += TestScore
       TestSubmit += 1
    Average = TotalScore / 500
    print("Your Average is : ", format(Average, '.1%'))


def determineGrade():
    GradeScore = float(input("Enter a test score"))
    if GradeScore >= 90:
        print("Your Grade is an A")
    elif GradeScore >= 80 and GradeScore < 90:
        print("Your Grade is a B")
    elif GradeScore >= 70 and GradeScore < 80:
        print("Your Grade is a C")
    elif GradeScore >= 60 and GradeScore < 70:
        print("Your Grade is a D")
    elif GradeScore < 60:
        print("Your Grade is an F, You Failed.")

def Main():
    CalcAverage();
    print('\n')
    print('\n')
    determineGrade();

Main();