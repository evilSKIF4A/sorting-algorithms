void CombSort(vector<int>& arr) {
    int n = arr.size();
    bool swappend = false;
    while (n > 1 || swappend)
    {
        n = (int)(n / 1.2473309);
        if (n < 1) n = 1;
        int i = 0, m = n;
        swappend = false;
        while (m < arr.size())
        {
            if (arr[i] > arr[m])
            {
                swappend = true;
                swap(arr[i], arr[m]);
            }
            i++;
            m = i + n;
        }
    }
}