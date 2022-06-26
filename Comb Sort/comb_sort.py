def CombSort(arr):
    n = len(arr)
    swappend = False
    while n > 1 or swappend:
        n = (int)(n / 1.2473309)
        if n < 1: 
            n = 1
        i = 0 
        m = n
        swappend = False
        while m < len(arr):
            if arr[i] > arr[m]:
                swappend = True
                arr[i], arr[m] = arr[m], arr[i]
            i += 1
            m = i + n
    return arr