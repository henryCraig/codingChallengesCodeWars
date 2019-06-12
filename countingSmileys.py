def count_smileys(smileyArray):
    smileyCount = 0

    for face in smileyArray:
        if len(face) > 0:
            if len(face) > 2:
                if face[1] == '-' or face[1] == '~':
                    if face[0] == ':' or face[0] == ';':
                        if face[len(face)-1] == 'D' or face[len(face)-1] == ')':
                            smileyCount += 1
            else:
                if face[0] == ':' or face[0] == ';':
                    if face[len(face)-1] == 'D' or face[len(face)-1] == ')':
                        smileyCount += 1

    return smileyCount

print(count_smileys([]))
print(count_smileys([':D',':~)',';~D',':)', '']))
print(count_smileys([':)',':(',':D',':O',':;']))
print(count_smileys([';]', ':[', ';*', ':$', ';-D']))



#So theres two issues that could be happening here
#there could be faces longer than two or three
#and therer could be improper noses being used
