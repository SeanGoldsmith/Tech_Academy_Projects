#assign an integer to a variable
myInteger = 5
#assign a string to a variable
myString = "Hello"
#assign a float to a variable
myFloat = 3.14
#print variables in a string using .format method
print ("Hi. {} is my integer, {} is my string, and {} is my float!".format(
    myInteger,myString,myFloat))

#use listed operators

x = 5
y = 2
print x + y
print x - y
print x * y
print x / y

x += y

x = y % 4

#Use logical operators
x = 5
y = 3
someBool = (x == 5) and (y == 5)
anotherBool = (x == 5) or (y == 5)
lastBool = not(x == 5)
print someBool
print anotherBool
print lastBool

#use conditional statements
x = 27
if x > 30:
    print ("x is a pretty big number")
elif x > 10:
    print ("x is a number with a reasonable size")
else:
    print ("x is a pretty small number")

#use a while loop

someCondition = True
while someCondition:
    choice = str(raw_input("Should I keep printing? y/n ")).lower()
    if choice == 'y':
        someCondition = True
    elif choice == 'n':
        someCondition = False
    else:
        print ("Next time, enter y or n.")
        someCondition = True

        
#Use a for Loop
print ("\nFor Loop example")
for i in range (1,11):
   
    print i
    

# Create a list and iterate through with a for loop and print
# each item on a new line
print ("\nIterate through a list.\n")
num_list = []
for i in range (0,11):
    num_list.append(float((i*5)/2))

for numbers in num_list:
    print numbers

#Create a tuple and iterate through with a for loop
print "\n"

myTuple = (5,7,9,11,13,15)

for z in range (0,len(myTuple)):
    print myTuple[z]

#Define a function that returns a string variable

def retString ():
    return "hello!"

test = retString()
print test

