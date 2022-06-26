def OddEvenSort(arr):
    for i in range(len(arr)):
        for j in range(0 if i % 2 == 0 else 1, len(arr), 2):
            if j + 1 < len(arr) and arr[j] > arr[j+1]:
                arr[j], arr[j+1] = arr[j+1], arr[j]
    return arr