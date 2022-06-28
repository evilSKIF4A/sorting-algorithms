const QuickSort = (arr, left, right) => {
  let x = arr[Math.floor((left + right) / 2)],
    i = left,
    j = right - 1;
  while (i <= j) {
    while (arr[i] < x) i++;
    while (arr[j] > x) j--;
    if (i <= j) [arr[i++], arr[j--]] = [arr[j], arr[i]];
  }
  if (left < j) arr = QuickSort(arr, left, j + 1);
  if (i < right) arr = QuickSort(arr, i, right);
  return arr;
};
