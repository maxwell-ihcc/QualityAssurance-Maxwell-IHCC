MenuChoice = ''
playerList = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12]
def menuInput():
    print("Welcome to the Baseball Player Info Station.", "'1' will allow a player's name to be entered", sep='\n')
    print("'2' will allow a players stats to be entered", "'3' will display a summary of player info.", sep='\n')
    MenuChoice = input("Choose what you want to do. ")
    return MenuChoice
def validateEntry(MenuChoice):
    print(MenuChoice)
    if not MenuChoice or MenuChoice.isdigit():   
        if int(MenuChoice) < 1 or int(MenuChoice) > 3:
            MenuChoice = input("Please enter a valid number between 1-3. ")
            validateEntry(MenuChoice);
        elif MenuChoice == 1:
            menuValid = True
            return MenuChoice
            playerEntry();
        elif MenuChoice == 2:
            return MenuChoice
            playerStats()

def playerEntry():
    for x in range(1,13):
        playerId = input("Please enter a player's ID")
        Playervalid = False
        while not (Playervalid):
            if playerId():
                if int(playerId) < 1 or int(playerId) > 12:
                    playerId = input("Player Number must be 1-12. Enter Player number.")
                else:
                    Playervalid = True
            else:
                playerId = input("Player Number must be numeric. Enter Course Number.")
        return playerId
    
def main():
   MenuChoice = menuInput();
   validateEntry(MenuChoice);
main();
        
