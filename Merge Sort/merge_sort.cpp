void MergeSort(vector<int>& arr, int left, int right) {
    if (right - left == 1) return;
    int mid = (left + right) / 2;
    MergeSort(arr, left, mid);
    MergeSort(arr, mid, right);
    vector<int> tempArray(arr.size());
    int i = left, j = mid, k = left;
    while (i < mid && j < right)
    {
        if (arr[i] <= arr[j]) tempArray[k++] = arr[i++];
        else tempArray[k++] = arr[j++];
    }
    while (i < mid) tempArray[k++] = arr[i++];
    while (j < right) tempArray[k++] = arr[j++];
    for (int t = left; t < right; t++) arr[t] = tempArray[t];
}