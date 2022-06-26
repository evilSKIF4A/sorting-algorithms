def MaximumNumber(arr):
    if len(arr) == 0: return 0
    mx = arr[0]
    for i in range(1, len(arr)):
        if mx < arr[i]:
            mx = arr[i]
    return mx

def CountingSort(arr):
    tempNum = MaximumNumber(arr)
    n = len(arr) if len(arr) > tempNum else tempNum + 1
    tempArr = [0] * n
    for i in range(len(arr)): tempArr[arr[i]]+= 1
    j = 0
    for i in range(n):
        while tempArr[i] != 0:
            arr[j] = i
            tempArr[i]-= 1
            j += 1
    return arr