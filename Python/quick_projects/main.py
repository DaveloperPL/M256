import random
 #allows us to gen rNum

when=['A few years ago', 'Yesterday', 'Today', 'Last night', 'This morning']
who=['a dog', 'a human', 'spiderman', 'Mr. Bean', 'a cat']
home=['Krakow', 'Chicago', 'Warsaw', 'Berlin', 'Stockholm']
went=['to the movies', 'to the golf course', 'to school', 'to london', 'on a bus']
happend=['got kicked out', 'got a conncussion', 'ate icecream', 'played video games', 'fell asleep']

print(random.choice(when) + ", " + random.choice(who) + " living in " + random.choice(home) + " when " + random.choice(went) + " then " + random.choice(happend))