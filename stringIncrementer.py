#https://www.codewars.com/kata/string-incrementer/train/python

def increment_string(strng):

    for i in range(len(strng)):
        if strng[i:].isdigit():
            originalNumLength = len(strng[i:len(strng)])
            newNum = str(int(strng[i:len(strng)])+1)
            while len(newNum) < originalNumLength:
                newNum = ("0" + newNum)

            return(strng[:i] + newNum)

    return strng + "1"

print(increment_string("foo"))
