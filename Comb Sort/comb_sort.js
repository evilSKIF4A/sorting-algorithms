const CombSort = (arr) => {
  let n = arr.length,
    swappend = false;
  while (n > 1 || swappend) {
    n = Math.floor(n / 1.2473309);
    if (n < 1) n = 1;
    let i = 0,
      m = n;
    swappend = false;
    while (m < arr.length) {
      if (arr[i] > arr[m]) {
        swappend = true;
        [arr[i], arr[m]] = [arr[m], arr[i]];
      }
      ++i;
      m = i + n;
    }
  }
  return arr;
};
