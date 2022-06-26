int MaximumNumber(vector<int> arr) {
    if (arr.size() == 0) return 0;
    int max = arr[0];
    for (int i = 1; i < arr.size(); ++i)
        if (max < arr[i])
            max = arr[i];
    return max;
}

void CountingSort(vector<int>& arr) {
    int temp = MaximumNumber(arr);
    int n = arr.size() > temp ? arr.size() : temp + 1;
    vector<int> tempArr(n, 0);
    for (int i = 0; i < arr.size(); i++) tempArr[arr[i]]++;
    int j = 0;
    for (int i = 0; i < n; i++)
        while (tempArr[i]-- != 0)
            arr[j++] = i;
}