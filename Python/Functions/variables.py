x=5

def add():
    global x
    x=x+1
    print(x)

def mult():
    global x
    x=x*2
    print(x)
    y=1
    y=y*10
    print(y)

def main():
    add()
    mult()

main()