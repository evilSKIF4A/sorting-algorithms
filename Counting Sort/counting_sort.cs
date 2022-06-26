internal static int MaximumNumber(int[] arr)
{
    if (arr.Length == 0) return 0;
    int max = arr[0];
    for (int i = 1; i < arr.Length; ++i)
        if (max < arr[i])
            max = arr[i];
    return max;
}
internal static int[] CountingSort(int[] arr)
{
    int temp = MaximumNumber(arr);
    int n = arr.Length > temp ? arr.Length : temp + 1;
    int[] tempArr = new int[n];
    for (int i = 0; i < arr.Length; i++) tempArr[arr[i]]++;
    int j = 0;
    for (int i = 0; i < n; i++)
        while (tempArr[i]-- != 0)
            arr[j++] = i;
    return arr;
}
