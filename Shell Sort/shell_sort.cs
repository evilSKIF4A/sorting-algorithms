internal static int[] shell_sort(int[] arr)
{
    for (int i = arr.Length / 2; i > 0; i /= 2)
        for (int j = i; j < arr.Length; ++j)
            for (int k = j - i; k >= 0 && arr[k] > arr[k + i]; k -= i)
            {
                int temp = arr[k];
                arr[k] = arr[k + i];
                arr[k + i] = temp;
            }
    return arr;
}