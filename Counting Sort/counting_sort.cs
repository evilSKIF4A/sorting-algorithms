internal static int[] counting_sort(int[] arr, int n)
{
    int[] tempArr = new int[n];
    for (int i = 0; i < n; i++) tempArr[arr[i]]++;
    int j = 0;
    for (int i = 0; i < n; i++)
    {
        while (tempArr[i]-- != 0)
        {
            arr[j++] = i;
        }
    }
    return arr;
}
