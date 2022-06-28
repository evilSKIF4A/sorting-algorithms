void heapify(vector<int>& arr, int n, int m)
{
    int max = m;
    int l = 2 * m + 1, r = 2 * m + 2;
    if (l < n && arr[max] < arr[l]) max = l;
    if (r < n && arr[max] < arr[r]) max = r;
    if (max != m)
    {
        swap(arr[max], arr[m]);
        heapify(arr, n, max);
    }
}

void HeapSort(vector<int>& arr, int n) {
    for (int j = n / 2 - 1; j >= 0; j--) heapify(arr, n,j);
    for (int i = n - 1; i >= 0; i--, n--)
    {
        swap(arr[0], arr[i]);
        heapify(arr, i, 0);
    }
}