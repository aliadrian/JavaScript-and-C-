/*

Given an array (arr) as an argument complete the function countSmileys that should return the total number of smiling faces.

Rules for a smiling face:

Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or ;
A smiley face can have a nose but it does not have to. Valid characters for a nose are - or ~
Every smiling face must have a smiling mouth that should be marked with either ) or D
No additional characters are allowed except for those mentioned.

Valid smiley face examples: :) :D ;-D :~)
Invalid smiley faces: ;( :> :} :]

Example
countSmileys([':)', ';(', ';}', ':-D']);       // should return 2;
countSmileys([';D', ':-(', ':-)', ';~)']);     // should return 3;
countSmileys([';]', ':[', ';*', ':$', ';-D']); // should return 1;
Note
In case of an empty array return 0. You will not be tested with invalid input (input will always be an array). Order of the face (eyes, nose, mouth) elements will always be the same.

*/

function countSmileys(arr) {
  return arr.filter((s) => /^[:;]{1}[~-]{0,1}[)D]{1}$/.test(s)).length;
}

const { assert } = require("chai");

describe("Basic testing", function () {
  it("Example tests", () => {
    assert.strictEqual(countSmileys([]), 0);
    assert.strictEqual(countSmileys([":D", ":~)", ";~D", ":)"]), 4);
    assert.strictEqual(countSmileys([":)", ":(", ":D", ":O", ":;"]), 2);
    assert.strictEqual(countSmileys([";]", ":[", ";*", ":$", ";-D"]), 1);
  });
});
