def MergeSort(arr, left, right):
    if (right - left == 1): 
        return arr
    mid = (left + right) // 2
    arr = MergeSort(arr, left, mid)
    arr = MergeSort(arr, mid, right)
    tempArray = [0] * len(arr)
    i = left 
    j = mid
    k = left
    while i < mid and j < right:
        if arr[i] <= arr[j]: 
            tempArray[k] = arr[i]
            i += 1
        else: 
            tempArray[k] = arr[j]
            j += 1
        k += 1
    while i < mid: 
        tempArray[k] = arr[i]
        k += 1
        i += 1
    while j < right:
        tempArray[k] = arr[j]
        k += 1
        j += 1
    for t in range(left, right):
        arr[t] = tempArray[t]
    return arr