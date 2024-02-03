// Instructions
// Subtract big numbers passed as strings

// Arguments are passed as strings
// Result should be returned as string
// 3 - 2 should return 1 while 2 - 3 should return -1
// Zeros should not preceed a number! 02, -02, 0001 are invalid
// Very large numbers will be tested

function subtract(a, b) {
  let result;

  result = BigInt(a) - BigInt(b);
  return BigInt(result).toString();
}

const Test = require("@codewars/test-compat");

describe("Some simple subtraction", function () {
  it("simple", function () {
    Test.assertEquals(subtract("2", "3"), "-1");
    Test.assertEquals(subtract("30", "69"), "-39");
    Test.assertEquals(subtract("6", "2"), "4");
    Test.assertEquals(subtract("85", "11"), "74");
  });
});

describe("Some corner case", function () {
  it("corner cases", function () {
    Test.assertEquals(subtract("2", "0"), "2");
    Test.assertEquals(subtract("0", "30"), "-30");
    Test.assertEquals(subtract("0000001", "3"), "-2");
    Test.assertEquals(subtract("1009", "03"), "1006");
    Test.assertEquals(subtract("234", "242"), "-8");
    Test.assertEquals(subtract("294", "334"), "-40");
  });
});

describe("Some big subtraction", function () {
  it("big boys", function () {
    Test.assertEquals(subtract("98765", "56894"), "41871");
    Test.assertEquals(
      subtract("1020303004875647366210", "2774537626200857473632627613"),
      "-2774536605897852597985261403"
    );
    Test.assertEquals(
      subtract("58608473622772837728372827", "7586374672263726736374"),
      "58600887248100574001636453"
    );
    Test.assertEquals(subtract("9007199254740991", "9007199254740991"), "0");
  });
});
