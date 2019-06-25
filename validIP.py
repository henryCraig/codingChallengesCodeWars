import re

#https://www.codewars.com/kata/ip-validation/train/python

#So I have some ideas here
#If i break up the string by . (periods) then the number of chunks can tell me

def is_valid_IP(inputString):

    if re.search("[a-zA-z]", inputString):
        return False

    #if len(inputstring) > 1:


    return False



ipList = "12.19".split(".")
print(ipList)
print(len(ipList))
