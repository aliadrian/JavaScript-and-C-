// sumStrings('1','2') // => '3'

function sumStrings(a, b) {
  let result;
  result = BigInt(a) + BigInt(b);
  return BigInt(result).toString();
}

const Test = require("@codewars/test-compat");

describe("Tests", () => {
  it("test", () => {
    Test.assertEquals(sumStrings("123", "456"), "579");
  });
});
