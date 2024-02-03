/*
Given a lowercase string that has alphabetic characters only and no spaces, return the highest value of consonant substrings. 
Consonants are any letters of the alphabet except "aeiou".

We shall assign the following values: a = 1, b = 2, c = 3, .... z = 26.

For example, for the word "zodiacs", let's cross out the vowels. We get: "z o d ia cs"

-- The consonant substrings are: "z", "d" and "cs" and the values are z = 26, d = 4 and cs = 3 + 19 = 22. The highest is 26.
solve("zodiacs") = 26

For the word "strength", solve("strength") = 57
-- The consonant substrings are: "str" and "ngth" with values "str" = 19 + 20 + 18 = 57 and "ngth" = 14 + 7 + 20 + 8 = 49. The highest is 57.
*/

function solve(s) {
	return Math.max(...s.split(/[aeiou]+/i).map(x => [...x].reduce((sum, c) => sum + c.charCodeAt(0) - 96, 0)));
};

const chai = require("chai");
const assert = chai.assert;
chai.config.truncateThreshold = 0;

describe("Basic tests", function () {
	it("Should pass sample tests", function () {
		assert.strictEqual(solve("zodiac"), 26);
		assert.strictEqual(solve("chruschtschov"), 80);
		assert.strictEqual(solve("khrushchev"), 38);
		assert.strictEqual(solve("strength"), 57);
		assert.strictEqual(solve("catchphrase"), 73);
		assert.strictEqual(solve("twelfthstreet"), 103);
		assert.strictEqual(solve("mischtschenkoana"), 80);
		assert.strictEqual(solve("az"), 26);
	});
});