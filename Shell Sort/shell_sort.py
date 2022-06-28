def ShellSort(arr):
    h = len(arr) // 2
    while h > 0:
        for i in range(h, len(arr)):
            t = arr[i]
            j = i
            while j >= h and arr[j - h] > t:
                arr[j] = arr[j - h]
                j -= h
            arr[j] = t
        h = h // 2
    return arr