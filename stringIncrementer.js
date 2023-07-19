function incrementString(strng) {
  let numbers;
  let randomString;
  const regex = /(\d+)$/;
  const match = strng.match(regex);

  if (match !== null) {
    numbers = match[0];
    randomString = strng.substring(0, match.index);
  } else {
    return strng + "1";
  }

  var sum = parseInt(numbers) + 1;
  var paddedSum = sum.toString().padStart(numbers.length, '0');
  return randomString + paddedSum;
}

describe("Tests suite", () => {

  const { assert } = require('chai');

  function doTest(input, expected) {
    const actual = incrementString(input);
    assert.strictEqual(actual, expected, `for string: "${input}"\n`);
  }

  it("sample tests", () => {
    doTest("foobar000", "foobar001");
    doTest("foobar999", "foobar1000");
    doTest("foobar00999", "foobar01000");
    doTest("foo", "foo1");
    doTest("foobar001", "foobar002");
    doTest("foobar1", "foobar2");
    doTest("1", "2");
    doTest("009", "010");
    doTest("fo99obar99", "fo99obar100");
  });
});