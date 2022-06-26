const OddEvenSort = (arr) => {
  for (let i = 0; i < arr.length; ++i)
    for (let j = i % 2 == 0 ? 0 : 1; j + 1 < arr.length; j += 2)
      if (arr[j] > arr[j + 1]) [arr[j], arr[j + 1]] = [arr[j + 1], arr[j]];
  return arr;
};
