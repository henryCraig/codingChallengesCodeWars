#https://www.codewars.com/kata/57fb44a12b53146fe1000136/train/python

def balance(left, right):
    leftAmount = 0
    rightAmount = 0
    for i in range(len(left)):
        if left[i] == "!":
            leftAmount += 2
        elif left[i] == "?":
            leftAmount += 3

    for i in range(len(right)):
        if right[i] == "!":
            rightAmount += 2
        elif right[i] == "?":
            rightAmount += 3

    if leftAmount > rightAmount:
        return "Left"
    elif rightAmount > leftAmount:
        return "Right"
    else:
        return "Balance"


print(balance("", ""))
print(balance("!!", "??"))
print(balance("!??", "?!!"))
print(balance("!?!!", "?!?"))
print(balance("!!???!????","??!!?!!!!!!!"))

# Test.assert_equals(balance("","") , "Balance")
# Test.assert_equals(balance("!!","??") , "Right")
# Test.assert_equals(balance("!??","?!!") , "Left")
# Test.assert_equals(balance("!?!!","?!?") , "Left")
# Test.assert_equals(balance("!!???!????","??!!?!!!!!!!") , "Balance")
