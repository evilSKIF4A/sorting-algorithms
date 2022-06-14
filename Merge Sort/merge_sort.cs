internal static int[] merge_sort(int[] arr, int left, int right)
{
    if (right - left == 1) return arr;
    int mid = (left + right) / 2;
    merge_sort(arr, left, mid);
    merge_sort(arr, mid, right);
    int[] tempArray = new int[arr.Length];
    int i = left, j = mid, k = left;
    while (i < mid && j < right)
    {
        if (arr[i] <= arr[j]) tempArray[k++] = arr[i++];
        else tempArray[k++] = arr[j++];
    }
    while (i < mid) tempArray[k++] = arr[i++];
    while (j < right) tempArray[k++] = arr[j++];
    for (int t = left; t < right; t++) arr[t] = tempArray[t];
    return arr;
}