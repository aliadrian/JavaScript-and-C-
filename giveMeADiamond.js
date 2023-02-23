// Output
//   *
//  ***
// *****
//  ***
//   *

//  "  *\n ***\n*****\n ***\n  *\n"

// My solution
function diamond(n) {
  if (n < 0 || n % 2 === 0) {
    return null;
  }

  let halfHeight = (n - 1) / 2;
  let diamond = "*".repeat(n) + "\n";

  for (let i = 1; i <= halfHeight; i++) {
    let stars = n - i * 2;
    let spaces = i;

    let line = " ".repeat(spaces) + "*".repeat(stars) + "\n";
    diamond = line + diamond + line;
  }

  return diamond;
}

// Better solution
function diamond(n) {
  if (n <= 0 || n % 2 === 0) return null;
  str = "";
  for (let i = 0; i < n; i++) {
    let len = Math.abs((n - 2 * i - 1) / 2);
    str += " ".repeat(len);
    str += "*".repeat(n - 2 * len);
    str += "\n";
  }
  return str;
}

const { assert } = require("chai");

describe("diamond()", function () {
  it("Valid diamonds", () => {
    assert.strictEqual(diamond(1), "*\n");
    assert.strictEqual(diamond(3), " *\n***\n *\n");
    assert.strictEqual(diamond(5), "  *\n ***\n*****\n ***\n  *\n");
  });

  it("Invalid diamonds", () => {
    assert.strictEqual(diamond(2), null);
    assert.strictEqual(diamond(-3), null);
    assert.strictEqual(diamond(0), null);
  });
});
