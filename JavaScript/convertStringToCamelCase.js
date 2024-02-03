function toCamelCase(str) {
  if (str.length > 0) {
    const words = str.split(/[_-]/);
    let camelCaseString = words[0];

    for (let i = 1; i < words.length; i++) {
      camelCaseString +=
        words[i][0].toUpperCase() + words[i].substr(1).toLowerCase();
    }
    return camelCaseString;
  } else {
    return "";
  }
}

const { assert } = require("chai");

describe("Tests", () => {
  it("test", () => {
    assert.strictEqual(
      toCamelCase(""),
      "",
      "An empty string was provided but not returned"
    );
    assert.strictEqual(
      toCamelCase("the_stealth_warrior"),
      "theStealthWarrior",
      "toCamelCase('the_stealth_warrior') did not return correct value"
    );
    assert.strictEqual(
      toCamelCase("The-Stealth-Warrior"),
      "TheStealthWarrior",
      "toCamelCase('The-Stealth-Warrior') did not return correct value"
    );
    assert.strictEqual(
      toCamelCase("A-B-C"),
      "ABC",
      "toCamelCase('A-B-C') did not return correct value"
    );
  });
});
