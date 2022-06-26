void OddEvenSort(vector<int>& arr) {
    for (int i = 0; i < arr.size(); ++i)
        for (int j = ((i % 2 == 0) ? 0 : 1); j + 1 < arr.size(); j += 2)
            if (arr[j] > arr[j + 1])
                swap(arr[j], arr[j + 1]);
}