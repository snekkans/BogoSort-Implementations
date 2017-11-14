#This is a simple python console application built with PyCharm Community
#that implements the BogoSort algorithm.
#The purpose of this was to quickly brush up on basic syntax that Python uses.

#Honestly this was probably the easiest implementation of Bogosort
#that I've done so far, since it was only two methods and wasn't
#required to output any information to, or even work with any
#sort of user interface, and that's the part that normally takes up
#significant chunks of time.
import random
#empty list and default isSorted boolean
valuesToSort=[]

#simple function that generates x values between 1 and x*10 for an array
def generateArray(x):
    for i in range (0,x):
        val = random.randint(1,x*10)
        valuesToSort.append(val)

def bogoSort(x):
    timesShuffled = 0
    random.shuffle(x)
    while x!=sorted(x):
        random.shuffle(x)
        timesShuffled=timesShuffled+1
    print("It took bogosort ",timesShuffled," to sort the array:")
    return x
#change the value in generateArray to generate more or less numbers
generateArray(10)
print("Initial array is ",valuesToSort)
#send a friendly message so the user knows we're doing "something"
print("Sorting, please wait...")
print(bogoSort(valuesToSort))