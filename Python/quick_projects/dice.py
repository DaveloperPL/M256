import random

min_value=1
max_value=6

roll_again="yes"

while roll_again=="yes" or roll_again=="y":
    print("Rolling the dice")
    print(random.randint(min_value,max_value))
    print(random.randint(min_value, max_value))
    roll_again = input("Roll again? (y/n)?")
