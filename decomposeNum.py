#decompose(11) must return [1,2,4,10]
#test.assert_equals(decompose(5), [3,4])
#test.assert_equals(decompose(8), None)

#https://www.codewars.com/kata/54eb33e5bc1a25440d000891/train/python

def decompose(n):
    print(n**2) #This is how we do powers

    #If we just start out at n-1 then everything will fit anyway
    #I cant figure out a way to not make this algorithm an n-squared algo
    #It feels like I would need to iterate over each small list too to figure out what works
    #I guess its not exactly n-squared, I think it might be a little better than that?

    for i in range(n-1, 0, -1):
        print("I: ", i)
        if i**2 < n**2:
            print( (i**2), ": is less than!")

    thisList = list(range( (n-1)**2, 0, -(n-2)**2))
    print(thisList)


    #16, 9, 4, 1

decompose(5)
