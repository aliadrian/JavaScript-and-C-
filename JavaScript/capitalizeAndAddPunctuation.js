function sentencify(words) {
  function capitalize(s) {
    return s[0].toUpperCase() + s.slice(1);
  }
  return capitalize(words.join(" ")) + ".";
}

const chai = require("chai");
const assert = chai.assert;
chai.config.truncateThreshold = 0;

describe("Fixed Test", () => {
  it("It should work for some examples.", () => {
    assert.strictEqual(sentencify(["i", "am", "an", "AI"]), "I am an AI.");
    assert.strictEqual(sentencify(["yes"]), "Yes.");
    assert.strictEqual(
      sentencify(["FIELDS", "of", "CORN", "are", "to", "be", "sown"]),
      "FIELDS of CORN are to be sown."
    );
    assert.strictEqual(
      sentencify(["i'm", "afraid", "I", "can't", "let", "you", "do", "that"]),
      "I'm afraid I can't let you do that."
    );
  });
  it("It should work for tricky sentences.", () => {
    assert.strictEqual(
      sentencify(["let", "there", "be", "light"]),
      "Let there be light."
    );
    assert.strictEqual(
      sentencify(["any", "other", "characters,,,", "should", "be", "ignored"]),
      "Any other characters,,, should be ignored."
    );
    assert.strictEqual(
      sentencify(["extra", "stuff\"''", "stays"]),
      "Extra stuff\"'' stays."
    );
  });
});

describe("Random Test", () => {
  const solution = (words) => {
    let sentence = words.join(" ") + ".";
    return sentence.charAt(0).toUpperCase() + sentence.slice(1);
  };
  const randWord = () =>
    Math.random()
      .toString(36)
      .replace(/[^a-z]+/g, "");
  const randSentence = () => Array(10).fill(0).map(randWord);

  for (let i = 0; i < 50; i++) {
    let words = randSentence();
    it(`Testing for ${JSON.stringify(words)}`, () => {
      assert.strictEqual(sentencify(words.slice()), solution(words));
    });
  }
});
