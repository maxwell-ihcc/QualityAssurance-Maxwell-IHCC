def init():
    teamName=open('teamnamefile.dat', 'a')
    return teamName

def main():
    teamName = init()
    for x in range (0,3):
        iName = input("Enter your team name ")
        teamName.write(iName + '\n')
    teamName.close()

main()
