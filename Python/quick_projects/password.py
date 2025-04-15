import random

pwlength=int(input("Enter the length of your password "))
s="abcdefghijklmnopqestuvwxyz1234567890!@#$%^&*()ABCDEFGHIJKLMNOPQRSTUVWXYZ"
password="".join(random.sample(s,pwlength))
print(password)