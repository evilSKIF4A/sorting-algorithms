def QuickSort(arr, left, right):
    x = arr[(left + right) // 2]
    i = left
    j = right - 1
    while i <= j:
        while arr[i] < x: i+= 1
        while arr[j] > x: j-= 1
        if i <= j:
            arr[i], arr[j] = arr[j], arr[i]
            i+= 1
            j-= 1
    if left < j: arr = QuickSort(arr, left, j + 1);
    if i < right: arr = QuickSort(arr, i, right);
    return arr