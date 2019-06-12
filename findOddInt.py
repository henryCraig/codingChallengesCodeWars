def find_it(seq):
    emptyDict = {}

    for num in seq:
        # print(num)
        if num in emptyDict:
            emptyDict[num] += 1
        else:
            emptyDict[num] = 1

    for pair in emptyDict.items():
        if pair[1] %3 == 0:
            return pair[0]



print(find_it([20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5]))
