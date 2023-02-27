// Instructions
// In this example you have to validate if a user input string is alphanumeric. The given string is not nil/null/NULL/None, so you don't have to check that.

// The string has the following conditions to be alphanumeric:

// At least one character ("" is not valid)
// Allowed characters are uppercase / lowercase latin letters and digits from 0 to 9
// No whitespaces / underscore

function alphanumeric(str) {
  // My solution
  const regexItem = new RegExp("[^A-Za-z0-9]");

  if (!regexItem.test(str) && str !== "") {
    return true;
  } else {
    return false;
  }

  // Shorter solution
  let alphanumeric = (s) => /^[a-z\d]+$/i.test(s);
  // or
  function alphanumeric(string) {
    return /^[0-9a-z]+$/i.test(string);
  }
}

const { assert } = require("chai");

describe("Tests", () => {
  it("test", () => {
    assert.strictEqual(alphanumeric("Mazinkaiser"), true);
    assert.strictEqual(alphanumeric("hello world_"), false);
    assert.strictEqual(alphanumeric("PassW0rd"), true);
    assert.strictEqual(alphanumeric("     "), false);
  });
});
