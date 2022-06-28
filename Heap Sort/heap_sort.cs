internal static int[] HeapSort(int[] arr, int n)
{
    for (int j = n / 2 - 1; j >= 0; j--) arr = heapify(arr, n, j);
    for (int i = n - 1; i >= 0; i--, n--)
    {
        int temp = arr[0];
        arr[0] = arr[i];
        arr[i] = temp;
        arr = heapify(arr, i, 0);
    }
    return arr;
}

private static int[] heapify(int[] arr, int n, int m)
{
    int max = m;
    int l = 2 * m + 1, r = 2 * m + 2;
    if (l < n && arr[max] < arr[l]) max = l;
    if (r < n && arr[max] < arr[r]) max = r;
    if (max != m)
    {
        int temp = arr[max];
        arr[max] = arr[m];
        arr[m] = temp;
        arr = heapify(arr, n, max);
    }
    return arr;
}
