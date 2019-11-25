#Maxwell Floyd
#Lab 6 Debugging
#11/4/19
fileKey = open("Exam.DAT", "r")
fileStud = open("StudAns.dat", "r")
cCorrectCtr = 0
cIncCtr = 0
ctr = 0
incList = []
x = 0
testList = []
studAnsList = []
incList.append(0)
testList.append(" ")
studAnsList.append(" ")

for iFileRec in fileKey:
    iFileRec = iFileRec.rstrip("\n")
    x += 1
    testList.append(iFileRec)

for iFileRec2 in fileStud:
    iFileRec2 = iFileRec2.rstrip("\n")
    x += 1
    studAnsList.append(iFileRec2)

for x in range(0,20):
    if testList[x] == " ":
        del testList[x]

for x in range(0,20):
    if studAnsList[x] == " ":
        del studAnsList[x]

for x in range(len(studAnsList)):
    if testList[x] == studAnsList[x]:
        cCorrectCtr += 1
        ctr += 1
    else:
        cIncCtr += 1
        ctr += 1
        incList.append(ctr)

if cCorrectCtr > 15:
    print("Student Passed the Exam" , "\n")
else:
    print("Student Failed the Exam", "\n")

print("Number of Correct Answers: ", cCorrectCtr, "\n")
print("Number of Incorrect Answers: ", cIncCtr, "\n")

for x in range(0,18):
    if incList[x] == 0:
        del incList[x]
print("Questions in Error Were: ", "\n")

for x in range(len(incList)):
    print(incList[x], end = " ")
print("\n")

