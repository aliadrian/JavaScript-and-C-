/*
  rotate("Hello") // => ["elloH", "lloHe", "loHel", "oHell", "Hello"]

  Each string in the list is a rotation of the input string "Hello". The first string "elloH" is obtained by moving the first letter "H" to the end of the string. The second string "lloHe" is obtained by moving the first two letters "He" to the end of the string, and so on. The last string in the list is the original input string "Hello", which has been rotated by a full circle.
*/

function rotate(str) {
  let result = [];

  for (let i = 0; i < str.length; i++) {
    result.push(str.slice(i + 1) + str.slice(0, i + 1));
  }

  return result;
}

const Test = require("@codewars/test-compat");

describe("Tests", () => {
  it("test", () => {
    var testOut = rotate("Hello");
    Test.assertEquals(testOut.includes("elloH"), true);
    Test.assertEquals(testOut.includes("lloHe"), true);
    Test.assertEquals(testOut.includes("loHel"), true);
    Test.assertEquals(testOut.includes("oHell"), true);
    Test.assertEquals(testOut.includes("Hello"), true);
  });
});
