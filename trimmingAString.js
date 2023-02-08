function trim(str, size) {
  if (str.length <= size) {
    return str.slice(0, size) + "...";
  } else if (str.length >= size) {
    return str.slice(0, size - 3) + "...";
  } else {
    return str;
  }
}

function trim(arr, size) {
  return arr.length <= size
    ? arr
    : arr.slice(0, arr.length >= 3 ? size - 3 : size) + "...";
}

const chai = require("chai");
const assert = chai.assert;
chai.config.truncateThreshold = 0;

describe("Sample Tests", () => {
  it("Should pass sample tests", () => {
    assert.strictEqual(trim("Creating kata is fun", 14), "Creating ka...");
    assert.strictEqual(trim("He", 1), "H...");
    assert.strictEqual(
      trim("Code Wars is pretty rad", 50),
      "Code Wars is pretty rad"
    );
  });
});
