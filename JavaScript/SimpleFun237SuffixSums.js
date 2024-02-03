// For a = [1, 2, 3], the output should be [6, 5, 3].

// b[0]= 1 + 2 + 3 = 6
// b[1]=     2 + 3 = 5
// b[2]=         3 = 3
// For a = [1, 2, 3, -6], the output should be [0, -1, -3, -6].

// b[0]= 1 + 2 + 3 - 6 = 0
// b[1]=     2 + 3 - 6 = -1
// b[2]=         3 - 6 = -3
// b[3]=           - 6 = -6

function suffixSums(a) {
  let sumAll = new Array(a.length);
  let total = 0;
  let x = 0;

  for (let i = 0; i < a.length + 1; i++) {
    sumAll[x] = total;
    total = 0;
    if (i > 0) {
      x++;
    }
    for (let j = 0 + i; j < a.length; j++) {
      total += a[j];
    }
  }

  return sumAll;
}

const Test = require("@codewars/test-compat");

describe("Basic Tests", function () {
  it("It should works for basic tests.", function () {
    Test.assertDeepEquals(suffixSums([1, 2, 3]), [6, 5, 3]);

    Test.assertDeepEquals(suffixSums([1, 2, 3, -6]), [0, -1, -3, -6]);

    Test.assertDeepEquals(suffixSums([0, 0, 0]), [0, 0, 0]);

    Test.assertDeepEquals(suffixSums([1, 123, 23]), [147, 146, 23]);
  });
});
