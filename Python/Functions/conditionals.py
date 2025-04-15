
count=0

def ques():
    global count
    inp=input("What month are we in?")
    if inp=="march":
        print("correct")
        count=count+1
    else:
        print("Wrong")

    print("What is 5+5?")
    inp=int(input())
    if inp==10:
        print("Correct")
        count=count+1
    else:
        print("wrong")

def score():
    score=(count/2)*100;
    if score>50:
        print("100%")
    elif score==50:
        print("50%")
    else:
        print("0%")

    print("You got " + str(count) + " correct")


def main():
    ques()
    score()
main()