/**
 * @param {string} text 
 *  Description of this parameter, which takes a string
 * @param {number} duplicateCount
 *  Description of this parameter, the number of characters that are repeated in 
*   @param {string text}
 * @returns @param {number} duplicateCount
 
 * Examples
  "abcde" -> 0 # no characters repeats more than once
  "aabbcde" -> 2 # 'a' and 'b'
  "aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
  "indivisibility" -> 1 # 'i' occurs six times
  "Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
  "aA11" -> 2 # 'a' and '1'
  "ABBA" -> 2 # 'A' and 'B' each occur twice
 */

function duplicateCount(text) {
  const charCount = new Map();
  const lowerStr = text.toLowerCase();

  for (const char of lowerStr) {
    if (charCount.has(char)) {
      charCount.set(char, charCount.get(char) + 1);
    } else {
      charCount.set(char, 1);
    }
  }

  let duplicateCount = 0;
  for (const count of charCount.values()) {
    if (count > 1) {
      duplicateCount++;
    }
  }

  return duplicateCount;
}

const { assert } = require('chai');

describe("Tests", () => {
  it("test", () => {
    assert.strictEqual(duplicateCount(""), 0);
    assert.strictEqual(duplicateCount("abcde"), 0);
    assert.strictEqual(duplicateCount("aabbcde"), 2);
    assert.strictEqual(duplicateCount("aabBcde"), 2, "should ignore case");
    assert.strictEqual(duplicateCount("Indivisibility"), 1)
    assert.strictEqual(duplicateCount("Indivisibilities"), 2, "characters may not be adjacent")
  });
});
