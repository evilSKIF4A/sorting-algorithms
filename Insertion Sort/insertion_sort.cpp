void InsertionSort(vector<int>& arr) {
    for (int i = 1; i < arr.size(); ++i)
        for (int j = i; j >= 1; --j)
        {
            if (arr[j - 1] <= arr[j])
                break;
            swap(arr[j], arr[j - 1]);
        }
}