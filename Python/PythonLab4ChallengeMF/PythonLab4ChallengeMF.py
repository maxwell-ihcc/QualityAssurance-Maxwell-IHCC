#Maxwell Floyd
#Lab 4 Challenge
#October 1st, 2019
cCtr = 1
cCtr2 = 1
while cCtr in range(1, 8, 1):
    if cCtr == 1:
        PoundText = "*******"
    elif cCtr == 2:
        PoundText = "******"
    elif cCtr == 3:
        PoundText = "*****"
    elif cCtr == 4:
        PoundText = "****"
    elif cCtr == 5:
        PoundText = "***"
    elif cCtr == 6:
        PoundText = "**"
    elif cCtr == 7:
        PoundText = "*"
    print(PoundText)
    cCtr += 1

print("------------------------------------------------------------------")

while cCtr2 in range(1, 8, 1):
    if cCtr2 == 1:
        TagText = "##"
    elif cCtr2 == 2:
        TagText = "# #"
    elif cCtr2 == 3:
        TagText = "#  #"
    elif cCtr2 == 4:
        TagText = "#   #"
    elif cCtr2 == 5:
        TagText = "#    #"
    elif cCtr2 == 6:
        TagText = "#     #"
    elif cCtr2 == 7:
        TagText = "#      #"
    print(TagText)
    cCtr2 += 1