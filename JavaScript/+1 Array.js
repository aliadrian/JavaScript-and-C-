/*
Given an array of integers of any length, return an array that has 1 added to the value represented by  the array.
1. the array can't be empty
2. only non-negative, single digit integers are allowed
Return null (or your language's equivalent) for invalid inputs.

Examples
Valid arrays
[4, 3, 2, 5] would return [4, 3, 2, 6]
[1, 2, 3, 9] would return [1, 2, 4, 0]
[9, 9, 9, 9] would return [1, 0, 0, 0, 0]
[0, 1, 3, 7] would return [0, 1, 3, 8]

Invalid arrays
[1, -9] is invalid because -9 is not a non-negative integer
[1, 2, 33] is invalid because 33 is not a single-digit integer
*/

function upArray(arr) {
  let list = [...arr];
  let z = list[list.length - 1] || 0;

  if (arr.length === 0 || Math.min(...list) < 0 || Math.max(...list) > 9) {
    return null;
  } else {
    if (z === 9) {
      let carry = 1;
      for (let j = list.length - 1; j >= 0; j--) {
        let digit = list[j] + carry;
        if (digit === 10) {
          list[j] = 0;
          carry = 1;
        } else {
          list[j] = digit;
          carry = 0;
          break;
        }
      }
      if (carry === 1) {
        list.unshift(1);
      }
      return list;
    } else {
      z++;
      arr[list.length - 1] = z;
      return arr;
    }
  }
}

const { assert } = require('chai');

describe("Tests", () => {
  it("test", () => {
    assert.sameOrderedMembers(upArray([4, 3, 2, 5]), [4, 3, 2, 6]);
    assert.sameOrderedMembers(upArray([2, 3, 9, 9]), [2, 4, 0, 0]);
    assert.sameOrderedMembers(upArray([9, 9]), [1, 0, 0]);
    assert.sameOrderedMembers(upArray([0, 7]), [0, 8]);
    assert.sameOrderedMembers(upArray([1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0]), [1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 1]);

    assert.isNull(upArray([1, -9]));
    assert.isNull(upArray([1, 10]));
  });
});
