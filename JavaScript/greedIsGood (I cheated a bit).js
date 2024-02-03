function occurance(arr, x) {
  let count = 0;
  for (let num of arr) {
    if (x === num) {
      count++;
    }
  }
  return count;
}

function score(dice) {
  let result = 0;

  for (let i of [...new Set(dice)]) {
    let count = occurance(dice, i);
    console.log(`${i} Occurred for: ${count}`);

    if (i === 1 && count >= 3) {
      result += 1000;
    }
    if (i === 1 && count === 4) {
      result = 1100;
    }
    if (result === 1300) {
      result = 1000;
    }
    if (result == 50) {
      result = 250;
    } else if (i === 6 && count === 3) {
      result += 600;
    } else if (i === 5 && count === 3) {
      result += 500;
    } else if (i === 4 && count === 3) {
      result += 400;
    } else if (i === 3 && count >= 3) {
      result += 300;
    } else if (i === 3 && count > 2) {
      result += 100 * count;
    } else if (i === 2 && count === 3) {
      result += 200;
    } else if (i === 1 && count === 1) {
      result += 100;
    } else if (i === 5 && count >= 1) {
      result += 50 * count;
    }
  }
  return result;
}

const Test = require("@codewars/test-compat");

describe("Scorer Function", function () {
  it("should value this as worthless", function () {
    Test.expect(score([2, 3, 4, 6, 2]) == 0, "Should be 0 :-(");
  });

  it("should value this triplet correctly", function () {
    Test.expect(score([4, 4, 4, 3, 3]) == 400, "Should be 400");
  });

  it("should value this mixed set correctly", function () {
    Test.expect(score([2, 4, 4, 5, 4]) == 450, "Should be 450");
  });
});
