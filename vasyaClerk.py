def tickets(moneyList):
    vasyasMoney = 0

    for singleAmount in moneyList:

        if singleAmount == 25:
            vasyasMoney += 25
        elif singleAmount > 25:
            vasyasMoney  += 25
            vasyasMoney = vasyasMoney - (singleAmount-25)


        print "Single Amount: ", singleAmount
        print "vasyasMoney end: ", vasyasMoney, "\n"

        if vasyasMoney < 0:
            return "NO"



    return "YES"


#print(tickets([25, 25, 50])) # => YES
#print(tickets([25, 100])) # => NO
#print(tickets([50])) #=> Should be yes
print(tickets([25, 25, 50, 50, 100])) #=> NO



#print(tickets([25, 25, 25, 25, 25, 100, 100])) # => YES
#alright so Im just going to notate this out so I can understand what will occur
#after 5 people vasya will have 125 dollars
#the 6th person will give 25, and then need 75 back
#so 150 - 75
#which is 75
#So this should return a YES
