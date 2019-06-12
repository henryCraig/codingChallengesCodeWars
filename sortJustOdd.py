def sort_array(source_array):

    if len(source_array) > 0:
        newOddList = []
        for num in source_array:
            if num % 2 != 0:
                newOddList.append(num)

        newOddList.sort()

        for i in range(len(source_array)):
            if (source_array[i] % 2 != 0):
                source_array[i] = newOddList.pop(0)

    return source_array




print(sort_array([5, 3, 1, 8, 0]))
