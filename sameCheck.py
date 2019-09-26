#https://www.codewars.com/kata/550498447451fbbd7600041c/train/python

def comp(array1, array2):
    if isinstance(array1, list) and isinstance(array2, list):
        if len(array1) == len(array2):
            array1.sort()
            array2.sort()
            for i in range(len(array1)):
                if array1[i]**2 != array2[i]:
                    return False
            return True
    return False



a = [121, 144, 19, 161, 19, 144, 19, 11]
b = [121, 14641, 20736, 361, 25921, 361, 20736, 361]
print(comp(a, b))

#"Same" means, here, that the elements in b are the elements in a squared, regardless of the order.
