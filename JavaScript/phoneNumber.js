// my solution
function createPhoneNumber(numbers) {
  let openParenthesis = "(";
  let closingParenthesis = ")";
  return (
    openParenthesis.concat(numbers.slice(0, 3).join("")) +
    closingParenthesis.concat(numbers.slice(3, 3).join("")) +
    " " +
    numbers.slice(3, 6).join("") +
    "-" +
    numbers.slice(6, 10).join("")
  );
}

// smartest solution
// let phoneNumber = "(xxx) xxx-xxx"

// for (let i = 0; i < numbers.length; i++) {
//     phoneNumber = phoneNumber.replace('x', numbers.replace[i]);
// }

// return phoneNumber;

chai.config.truncateThreshold = 0;

describe("Create Phone Number", () => {
  it("Fixed tests", () => {
    assert.strictEqual(
      createPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]),
      "(123) 456-7890"
    );
    assert.strictEqual(
      createPhoneNumber([1, 1, 1, 1, 1, 1, 1, 1, 1, 1]),
      "(111) 111-1111"
    );
    assert.strictEqual(
      createPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]),
      "(123) 456-7890"
    );
  });
});
