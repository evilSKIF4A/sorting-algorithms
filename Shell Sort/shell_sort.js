const ShellSort = (arr) => {
  for (let i = arr.length / 2; i > 0; i = Math.floor(i / 2))
    for (let j = i; j < arr.length; ++j)
      for (let k = j - i; k >= 0 && arr[k] > arr[k + i]; k -= i)
        [arr[k], arr[k + i]] = [arr[k + i], arr[k]];
  return arr;
};
