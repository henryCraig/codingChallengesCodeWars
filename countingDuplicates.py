def duplicate_count(text):
    checkDict = {}
    returnNum = 0

    for char in text:
        if char.lower() in checkDict.keys():
            checkDict[char.lower()] = checkDict[char.lower()]+1
        else:
            checkDict.update({ char.lower() : 1})
    for key in checkDict:
        if checkDict[key] > 1:
            returnNum += 1
    return returnNum

print(duplicate_count("aabbcde"))
