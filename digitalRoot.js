// 16  -->  1 + 6 = 7
// 942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
// 132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
// 493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2

function digitalRoot(n) {
  let s = n.toString();
  let sum = 0;
  for (let i = 0; i < s.length; i++) {
    let x = parseInt(s[i]);
    sum += x;
  }

  let newSum;
  if (sum.toString().length >= 2) {
    newSum = digitalRoot(sum);
  } else {
    return sum;
  }

  return newSum;
}

const chai = require("chai");
const assert = chai.assert;
chai.config.truncateThreshold = 0;

describe("Tests", () => {
  it("test", () => {
    assert.strictEqual(digitalRoot(16), 7);
    assert.strictEqual(digitalRoot(456), 6);
  });
});
