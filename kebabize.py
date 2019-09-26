import re

#https://www.codewars.com/kata/57f8ff867a28db569e000c4a/train/python

def kebabize(string):


    numberLess = re.split("[]",string)

    print(re.split("[A-Z]", string))
    splitString = re.split("[A-Z]", string)

    placement = 1
    for i in range(len(string)):
        if string[i].isupper():
            splitString[placement] = string[i] + splitString[placement]
            placement += 1

    print("splitString: ", splitString)


    if string[0].isupper():
        splitString.remove("")
    return ("-".join(splitString)).lower()

    #So this works on base cases, now we need to get rid of any numbers


print(kebabize("CodeWars"))
print(kebabize("myCamelCasedString"))
print(kebabize("SOS"))
print(kebabize("42"))


# Test.assert_equals(kebabize('42'), '')
# Test.assert_equals(kebabize('CodeWars'), 'code-wars')
