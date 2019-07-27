def narcissistic(value):
    lenValueStr = len(str(value))
    totalAmount = 0
    for digit in (str(value)):
        totalAmount += (int(digit) ** lenValueStr)
    if value == totalAmount:
        return True
    else:
        return False
print(narcissistic(153))
