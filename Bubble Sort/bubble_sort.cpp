void bubble_sort(vector<int>& arr) {
    for (int i = 0; i < arr.size(); i++)
        for (int j = 1; j < arr.size(); j++)
            if (arr[j] < arr[j - 1])
                swap(arr[j], arr[j - 1]);
}