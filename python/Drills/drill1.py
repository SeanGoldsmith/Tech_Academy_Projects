import datetime

newYork = datetime.datetime.now().hour + 3
london = datetime.datetime.now().hour + 8

if newYork >= 9 and newYork < 21:
    print("The New York office is OPEN")
else:
    print("The New York office is CLOSED")

if london >= 9 and london < 21:
    print("The London office is OPEN")
else:
    print("The London office is CLOSED")






