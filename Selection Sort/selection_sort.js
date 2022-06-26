const SelectionSort = (arr) => {
  for (let i = 0; i < arr.length; ++i) {
    let k = i;
    for (let j = i + 1; j < arr.length; ++j) if (arr[k] > arr[j]) k = j;
    [arr[i], arr[k]] = [arr[k], arr[i]];
  }
  return arr;
};
