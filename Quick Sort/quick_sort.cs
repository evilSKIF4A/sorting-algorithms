internal static int[] QuickSort(int[] arr, int left, int right)
{
    int x = arr[(left + right) / 2];
    int i = left, j = right - 1;
    while (i <= j)
    {
        while (arr[i] < x) i++;
        while (arr[j] > x) j--;
        if (i <= j)
        {
            int temp = arr[i];
            arr[i++] = arr[j];
            arr[j--] = temp;
        }
    }
    if (left < j) arr = quick_sort(arr, left, j + 1);
    if (i < right) arr = quick_sort(arr, i, right);
    return arr;
}
