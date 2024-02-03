/*
Complete the function scramble(str1, str2) that returns true if a portion of str1 characters can be rearranged to match str2, otherwise returns false.

Notes:

Only lower case letters will be used (a-z). No punctuation or digits will be included.
Performance needs to be considered.

Examples
scramble('rkqodlw', 'world') ==> True
scramble('cedewaraaossoqqyt', 'codewars') ==> True
scramble('katas', 'steak') ==> False
*/

function scramble(str1, str2) {
  const charCount = {};

  // Count the characters in str1
  for (let char of str1) {
    charCount[char] = (charCount[char] || 0) + 1;
  }

  // Check if characters in str2 can be formed using str1
  for (let char of str2) {
    if (!charCount[char]) {
      return false;
    }
    charCount[char]--;
  }

  return true;
}

const chai = require("chai");
const assert = chai.assert;
chai.config.truncateThreshold = 0;

describe('Sample Tests', function () {
  it("Tests", () => {
    assert.strictEqual(scramble('rkqodlw', 'world'), true);
    assert.strictEqual(scramble('cedewaraaossoqqyt', 'codewars'), true);
    assert.strictEqual(scramble('katas', 'steak'), false);
    assert.strictEqual(scramble('scriptjavx', 'javascript'), false);
    assert.strictEqual(scramble('scriptingjava', 'javascript'), true);
    assert.strictEqual(scramble('scriptsjava', 'javascripts'), true);
    assert.strictEqual(scramble('javscripts', 'javascript'), false);
    assert.strictEqual(scramble('jscripts', 'javascript'), false);
    assert.strictEqual(scramble('aabbcamaomsccdd', 'commas'), true);
    assert.strictEqual(scramble('commas', 'commas'), true);
    assert.strictEqual(scramble('sammoc', 'commas'), true)
  });

  it("Large inputs test", () => {
    let s1 = "abcdefghijklmnopqrstuvwxyz".repeat(10_000);
    let s2 = "zyxcba".repeat(9_000);
    assert.strictEqual(scramble(s1, s2), true);
  });
});