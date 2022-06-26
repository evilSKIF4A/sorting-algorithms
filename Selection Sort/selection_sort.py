def SelectionSort(arr):
    for i in range(len(arr)):
        k = i
        for j in range(i + 1, len(arr)):
            if arr[k] > arr[j]:
                k = j
        arr[i], arr[k] = arr[k], arr[i]
    return arr