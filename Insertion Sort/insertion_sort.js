const InsertionSort = (arr) => {
  for (let i = 1; i < arr.length; ++i)
    for (let j = i; j >= 1; --j) {
      if (arr[j - 1] <= arr[j]) break;
      [arr[j], arr[j - 1]] = [arr[j - 1], arr[j]];
    }
  return arr;
};
