def multiplication_table(row,col):
    returnTable = [[ ((j+1)*i) for j in range(col)] for i in range(row+1)]
    returnTable.pop(0)
    return returnTable

print(multiplication_table(3,3))
