const heapify = (arr, n, m) => {
  let max = m,
    l = 2 * m + 1,
    r = 2 * m + 2;
  if (l < n && arr[max] < arr[l]) max = l;
  if (r < n && arr[max] < arr[r]) max = r;
  if (max != m) {
    [arr[max], arr[m]] = [arr[m], arr[max]];
    heapify(arr, n, max);
  }
};

const HeapSort = (arr) => {
  let n = arr.length;
  for (let j = n; j >= 0; j--) heapify(arr, n, j);
  for (let i = n - 1; i >= 0; i--, n--) {
    [arr[0], arr[i]] = [arr[i], arr[0]];
    heapify(arr, i, 0);
  }
};
