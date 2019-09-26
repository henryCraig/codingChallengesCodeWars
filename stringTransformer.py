#https://www.codewars.com/kata/5878520d52628a092f0002d0/train/python

def string_transformer(s):

    #The Plan
    #Split it into multiple parts
    #Iterate backwards over those multiple parts
        #While iterating backwords iterate over each letter to alternate casing

    splitList = s.split()
    returnString = ""

    for i in range(len(splitList)-1, -1, -1):
        print(i)
        print(splitList[i])
        for j in splitList[i]:
            print(j)
            if j.isupper():
                returnString += j.lower()
            else:
                returnString += j.upper()

        returnString += " "



    print(returnString)
    return returnString[:len(returnString)-1]

string_transformer("Example string")


# test.assert_equals(string_transformer("Example string"), "STRING eXAMPLE")
# test.assert_equals(string_transformer("Example Input"), "iNPUT eXAMPLE")
