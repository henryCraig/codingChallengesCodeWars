#https://www.codewars.com/kata/primorial-of-a-number/train/python

def num_primorial(n):
    primeList = [2]
    trackingNum = 3
    iter = 3

    while len(primeList) < n:
        addNum = True
        for j in range(len(primeList)):
            if iter % primeList[j] == 0:
                addNum = False
                break
        if addNum == True:
            primeList.append(iter)
        iter += 1

    returnNum = 1
    for num in primeList:
        returnNum *= num

    return returnNum


num_primorial(3)
num_primorial(4)
num_primorial(5)
