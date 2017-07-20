#   Second argument is optional.
#   Entering any value as second
#...parameter will reverse output.

import random

def bubSort(numList,isRev='no',):
    if isRev == 'no':
    
        for x in range(0,len(numList)):
            for i in range(0,( len( numList )-1) ):
                if numList[i] > numList[i+1]:
                    hold = numList[i+1]
                    numList[i+1] = numList[i]
                    numList[i] = hold
        return numList
    else:
        for x in range(0,len(numList)):
            for i in range(0,( len( numList )-1) ):
                if numList[i] < numList[i+1]:
                    hold = numList[i+1]
                    numList[i+1] = numList[i]
                    numList[i] = hold
        return numList

startingList = []

for i in range(0,101):
    startingList.append(random.randint(0,100))
            
print startingList
newList = bubSort(startingList,0)
print ("\n")
print newList
