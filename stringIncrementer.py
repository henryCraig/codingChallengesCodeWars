def increment_string(strng):

    for i in range(len(strng)):

        print(i)
        print(strng[i])
        print()

        if strng[i].isdigit():
            if int(strng[i]) > 0:
                return(strng[:i] + str(int(strng[i:len(strng)])+1))

            elif i == len(strng):
                return(strng[:i] + str(int(strng[i])+1))

    return strng + "1"


print(increment_string("foobar00"))



#Test.assert_equals(increment_string("foo"), "foo1")
#Test.assert_equals(increment_string("foobar001"), "foobar002")
