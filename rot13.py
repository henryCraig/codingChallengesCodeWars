def rot13(message):
    returnString = ""
    for char in message:
        if char.isalpha():
            lowerChar = char.lower()
            ascVal = (ord(lowerChar)+13)
            if ascVal > 122:
                ascVal -= 26
            if char.isupper():
                returnString += (chr(ascVal)).upper()
            else:
                returnString += chr(ascVal)
        else:
            returnString += char
    return returnString

print(rot13("test"))
