def square_digits(num):
    num = str(num)
    returnString = ""

    for char in num:
        print(str(int(char)**2))
        returnString += (str(int(char)**2))

    return returnString

print(square_digits(1563))
