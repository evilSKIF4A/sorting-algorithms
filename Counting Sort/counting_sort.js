const MaximumNumber = (arr) => {
  if (arr.length == 0) return 0;
  let max = arr[0];
  for (let i = 1; i < arr.length; ++i) if (max < arr[i]) max = arr[i];
  return max;
};

const CountingSort = (arr) => {
  let temp = MaximumNumber(arr);
  let n = arr.length > temp ? arr.length : temp + 1;
  let tempArr = Array(n).fill(0);
  for (let i = 0; i < arr.length; i++) tempArr[arr[i]]++;
  let j = 0;
  for (let i = 0; i < n; i++) while (tempArr[i]-- !== 0) arr[j++] = i;
  return arr;
};
