const MergeSort = (arr, left, right) => {
  if (right - left == 1) return arr;
  let mid = Math.floor((left + right) / 2);
  arr = MergeSort(arr, left, mid);
  arr = MergeSort(arr, mid, right);
  let tempArray = Array(arr.length),
    i = left,
    j = mid,
    k = left;
  while (i < mid && j < right) {
    if (arr[i] <= arr[j]) tempArray[k++] = arr[i++];
    else tempArray[k++] = arr[j++];
  }
  while (i < mid) tempArray[k++] = arr[i++];
  while (j < right) tempArray[k++] = arr[j++];
  for (let t = left; t < right; t++) arr[t] = tempArray[t];
  return arr;
};
