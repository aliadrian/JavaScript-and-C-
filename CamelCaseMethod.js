/*
  "hello case".camelCase() => HelloCase
  "camel case word".camelCase() => CamelCaseWord
*/

String.prototype.camelCase = function () {
  let camelCase = this.trim().split(" ");
  let newString = "";

  for (let i = 0; i < camelCase.length; i++) {
    let s = camelCase[i];

    if (s.length > 0) {
      newString += s.charAt(0).toUpperCase() + s.slice(1);
    }
  }

  return newString;
};

const { assert } = require("chai");

it("Basic tests", () => {
  assert.strictEqual("test case".camelCase(), "TestCase");
  assert.strictEqual("camel Case method".camelCase(), "CamelCaseMethod");
  assert.strictEqual("say hello".camelCase(), "SayHello");
  assert.strictEqual("camel case word".camelCase(), "CamelCaseWord");
  assert.strictEqual("".camelCase(), "");
});
