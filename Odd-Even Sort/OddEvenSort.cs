internal static int[] OddEvenSort(int[] arr)
{
    for(int i = 0; i < arr.Length; ++i)
        for (int j = ((i % 2 == 0) ? 0 : 1); j + 1 < arr.Length; j += 2)
            if (arr[j] > arr[j + 1])
            {
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
    return arr;
}