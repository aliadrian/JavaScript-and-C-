// ['a','b','c','d','f'] -> 'e'
// ['O','Q','R','S'] -> 'P'

function findMissingLetter(array) {
  for (let i = 1; i < array.length; i++) {
    if (array[i].charCodeAt(0) - array[i - 1].charCodeAt(0) !== 1) {
      return String.fromCharCode(array[i].charCodeAt(0) - 1);
    }
  }

  throw new Error("No return value");
}

const Test = require("@codewars/test-compat");

describe("KataTests", function () {
  it("exampleTests", function () {
    Test.assertEquals(findMissingLetter(["a", "b", "c", "d", "f"]), "e");
    Test.assertEquals(findMissingLetter(["O", "Q", "R", "S"]), "P");
  });
});
