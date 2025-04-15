import random
choices=["Rock", "Paper","Scissors"]
computer=random.choice(choices)

comp_score=0
player_score=0

while True:
    player=input("Rock, Paper or Scissors?").capitalize()
    if player==computer:
        print("Tie")
    elif player=="Rock":
        if computer=="Paper":
            print("You lose!,", computer," covers ", player)
            comp_score=comp_score+1
        else:
            print("You won!,", player," smashes ", computer)
            player_score=player_score+1
    elif player=="Paper":
        if computer=="Rock":
            print("You win!,", player, " covers ", computer)
        else:
            print("You lose!,", computer, " cuts ", player)
    elif player=="Scissors":
        if computer=="Rock":
            print("You lose!,", computer, " smashes ", player)
        else:
            print("You win!,", player, " cuts ", computer)
    computer = random.choice(choices)
    print("Computer score: ", str(comp_score))
    print("Player score: ", str(player_score))