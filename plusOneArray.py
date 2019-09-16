def up_array(arr):
    if len(arr) == 0:
        return None

    totalNum = 0
    for i in range(len(arr)-1, -1, -1):
        totalNum += arr[len(arr)-1-i] * (10**i)

        if arr[len(arr)-1-i] < 0:
            return None
        elif arr[len(arr)-1-i] > 9:
            return None
            
    return [int(i) for i in str(totalNum+1)]

print(up_array([10, 0, 4, 2, 6, 2]))
