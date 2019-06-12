#So the idea is to iterate over a string
#if a particular character only shows up once then turn it into a "("
#else turn it into a ")"

#So what I want to do is create a dictionary
#where each character I see is a key to the dictionary
#and each value attached to the key is the amount of that object inside the array
print()

def duplicate_encode(word):
    word = word.lower()
    charDict = {}
    returnString = ""

    for char in word:
        if char in charDict:
            charDict[char] += 1
        else:
            charDict[char] = 1

    print("charDict: ", charDict)

    for char in word:
        if charDict[char] > 1:
            returnString += ")"
        else:
            returnString += "("

    print("returnString: ", returnString, "\n")



duplicate_encode("din") #Should return "((("
duplicate_encode("recede") #Should return "()()()"

duplicate_encode("Success") #Should return ")())())"
duplicate_encode("(( @" ) #Should return "))(("


#So the first thing I want to do is add keys to a dictionary
#I also want to check to see if a key already exists before adding


# charDict = {}
# print("charDict: ", charDict)
# charDict["a"] = 1
# print("charDict: ", charDict)
#
#
# if 'a' in charDict:
#     print('a is in')
# else:
#     print("a is OUT")










#space
