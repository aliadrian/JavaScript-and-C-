// my solution
function booleanToString(b) {
  if (b == true) {
    return b.toString();
  } else {
    return b.toString();
  }
}

// better solution
function booleanToString(b) {
  return b.toString();
}

const Test = require("@codewars/test-compat");

describe("Solution", function () {
  it("Fixed Tests", function () {
    Test.assertEquals(
      booleanToString(true),
      "true",
      'When we pass in true, we want the string "true" as output'
    );
    Test.assertEquals(
      booleanToString(false),
      "false",
      'When we pass in false, we want the string "false" as output'
    );
    Test.assertEquals(
      booleanToString(false),
      "false",
      'When we pass in false, we want the string "false" as output'
    );
  });
  it("Random Tests", function () {
    Array(40)
      .fill(0)
      .forEach(() => {
        const val = Math.random() < 0.5,
          exp = val ? "true" : "false";
        Test.assertEquals(
          booleanToString(val),
          exp,
          `When we pass in ${exp}, we want the string "${exp}" as output`
        );
      });
  });
});
