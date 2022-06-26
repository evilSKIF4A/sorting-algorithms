internal static int[] bubble_sort(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        for(int j = 1; j < arr.Length; j++)
            if (arr[j] < arr[j - 1])
            {
                int t = arr[j];
                arr[j] = arr[j - 1];
                arr[j - 1] = t;
            }
    return arr;
}
