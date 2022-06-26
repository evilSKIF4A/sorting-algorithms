void SelectionSort(vector<int>& arr) {
    for (int i = 0; i < arr.size(); ++i)
    {
        int k = i;
        for (int j = i + 1; j < arr.size(); ++j)
            if (arr[k] > arr[j])
                k = j;
        swap(arr[i], arr[k]);
    }
}