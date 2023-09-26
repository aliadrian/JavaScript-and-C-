function solution(str) {

	if (str.length % 2 === 1)
		str += "_";

	const list = [];
	for (let i = 0; i < str.length; i += 2) {
		list.push(str.charAt(i) + str.charAt(i + 1));
	}

	return list;
}

const { assert } = require('chai');

describe("Split Strings", () => {
	it("Basic tests", () => {
		assert.deepEqual(solution("abcdef"), ["ab", "cd", "ef"]);
		assert.deepEqual(solution("abcdefg"), ["ab", "cd", "ef", "g_"]);
		assert.deepEqual(solution(""), []);
	});
});