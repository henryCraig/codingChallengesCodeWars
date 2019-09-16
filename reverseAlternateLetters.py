#if i % 2 != 0:
    #Then reverse the word and make it that index's value
    #Now I just need to


def reverse_alternate(string):
  stringList = string.split(" ")
  stringList = [i for i in stringList if i != '']

  for i in range(len(stringList)):
      if i % 2 != 0:
          stringList[i] = stringList[i][::-1]

  return(" ".join(stringList))


print(reverse_alternate("I really hope it works this time..."))
