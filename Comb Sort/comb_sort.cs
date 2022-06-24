internal static int[] comb_sort(int[] arr)
{
    int n = arr.Length;
    bool swappend = false;
    while (n > 1 || swappend)
    {
        n = (int)(n / 1.2473309);
        if (n < 1) n = 1;
        int i = 0, m = n;
        swappend = false;
        while (m < arr.Length)
        {
            if (arr[i] > arr[m])
            {
                swappend = true;
                int t = arr[i];
                arr[i] = arr[m];
                arr[m] = t;
            }
            i++;
            m = i + n;
        }
    }
    return arr;
}
