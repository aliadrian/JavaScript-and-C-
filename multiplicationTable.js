// Istructions
// Your task, is to create N×N multiplication table, of size provided in parameter.

// For example, when given size is 3:

// 1 2 3
// 2 4 6
// 3 6 9
// For the given example, the return value should be:

// [[1,2,3],[2,4,6],[3,6,9]]

// My solution

multiplicationTable = function (size) {
  let result = [];
  for (let i = 1; i <= size; i++) {
    let multiplication = [];
    for (let j = 1; j <= size; j++) {
      multiplication.push(i * j);
    }
    result.push(multiplication);
  }

  return result;
};

// Another solution
// multiplicationTable = function (size) {
//   var result = [];

//   for (var i = 0; i < size; i++) {
//     result[i] = [];
//     for (var j = 0; j < size; j++) {
//       result[i][j] = (i + 1) * (j + 1);
//     }
//   }

//   return result;
// };

const Test = require("@codewars/test-compat");

describe("Tests", () => {
  it("test", () => {
    Test.assertSimilar(multiplicationTable(3), [
      [1, 2, 3],
      [2, 4, 6],
      [3, 6, 9],
    ]);
  });
});
