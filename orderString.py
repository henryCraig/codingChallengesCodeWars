def order(givenString):

    if len(givenString) > 0:
        givenStringArray = givenString.split(" ")

        returnList = [None] * len(givenStringArray)

        for word in givenStringArray:
            for i in range(len(givenStringArray)):
                if str(i+1) in word:
                    returnList[i] = word
                    break

        return " ".join(returnList)
    else:
        return givenString



print(order("thi3ng worl2d hel10"))
