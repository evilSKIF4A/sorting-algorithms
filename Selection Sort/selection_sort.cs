internal static int[] SelectionSort(int[] arr)
{
    for(int i = 0; i < arr.Length; ++i)
    {
        int k = i;
        for(int j = i + 1; j < arr.Length; ++j)
        {
            if (arr[k] > arr[j])
                k = j;
        }
        int temp = arr[i];
        arr[i] = arr[k];
        arr[k] = temp;
    }
    return arr;
}
