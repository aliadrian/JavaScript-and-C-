// https://en.wikipedia.org/wiki/Narcissistic_number
// 1^3 + 5^3 + 3^3 = 1 + 125 + 27 = 153
// and 1652 (4 digits), which isn't:
//     1^4 + 6^4 + 5^4 + 2^4 = 1 + 1296 + 625 + 16 = 1938

function narcissistic(value) {
  let sum = 0;

  for (let i of value.toString()) {
    sum += Math.pow(parseInt(i), value.toString().length);
  }

  if (value == sum) {
    return true;
  } else {
    return false;
  }
}

const { assert } = require("chai");

describe("Example tests", function () {
  function dotest(input, expected) {
    const actual = narcissistic(input);
    assert.strictEqual(actual, expected, `Incorrect answer for value=${input}`);
  }

  it("Narcissistic numbers", function () {
    dotest(7, true);
    dotest(153, true);
  });

  it("Not narcissistic numbers", function () {
    dotest(122, false);
    dotest(487, false);
  });
});
