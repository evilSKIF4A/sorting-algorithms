void QuickSort(vector<int>& arr, int left, int right) {
    int x = arr[(left + right) / 2];
    int i = left, j = right - 1;
    while (i <= j)
    {
        while (arr[i] < x) i++;
        while (arr[j] > x) j--;
        if (i <= j)
            swap(arr[i++], arr[j--]);
    }
    if (left < j) QuickSort(arr, left, j + 1);
    if (i < right) QuickSort(arr, i, right);
}