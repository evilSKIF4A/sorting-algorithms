internal static int[] insertion_sort(int[] arr)
{
    for(int i = 1; i < arr.Length; ++i)
    {
        for(int j = i; j >= 1; --j)
        {
            if (arr[j - 1] <= arr[j])
                break;
            int temp = arr[j];
            arr[j] = arr[j - 1];
            arr[j - 1] = temp;
        }
    }
    return arr;
}