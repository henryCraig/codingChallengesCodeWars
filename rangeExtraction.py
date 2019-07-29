def solution(args):
    iter = 0
    returnList = []
    args.append(0)
    
    for i in range(len(args)-1):
        if args[i] - args[i+1] == -1:
            iter += 1
        else:
            if iter > 1:
                returnList.append(str(args[i]-iter) + "-" + str(args[i]))
                iter = 0
            elif iter > 0:
                returnList.append(str(args[i-1]))
                returnList.append(str(args[i]))
                iter = 0
            else:
                returnList.append(str(args[i]))
                iter = 0
    return ",".join(returnList)


print(solution([-6,-3,-2,-1,0,1,3,4,5,7,8,9,10,11,14,15,17,18,19,20]))
#Test.assert_equals(solution([-6,-3,-2,-1,0,1,3,4,5,7,8,9,10,11,14,15,17,18,19,20])
#'-6, -3-1, 3-5, 7-11, 14, 15, 17-20'
