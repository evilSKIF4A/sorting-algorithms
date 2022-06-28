void ShellSort(vector<int>& arr) {
    for (int i = arr.size() / 2; i > 0; i /= 2)
        for (int j = i; j < arr.size(); ++j)
            for (int k = j - i; k >= 0 && arr[k] > arr[k + i]; k -= i)
                swap(arr[k], arr[k + i]);
}