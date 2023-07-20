/*
tripledouble(451999277, 41177722899) == 1 // num1 has straight triple 999s and num2 has straight double 99s
tripledouble(1222345, 12345) == 0 // num1 has straight triple 2s but num2 has only a single 2
tripledouble(12345, 12345) == 0
tripledouble(666789, 12345667) == 1
*/

function tripledouble(num1, num2) {
  for (let i = 0; i <= 9; i++) {
    const digitStr = i.toString();
    if (num1.toString().includes(digitStr.repeat(3))) {
      if (num2.toString().includes(digitStr.repeat(2))) {
        return 1;
      }
    }
  }
  return 0;
}

describe('Initial Tests', () => {
  Test.assertEquals(tripledouble(451999277, 41177722899), 1);
  Test.assertEquals(tripledouble(1222345, 12345), 0);
  Test.assertEquals(tripledouble(12345, 12345), 0);
  Test.assertEquals(tripledouble(666789, 12345667), 1);
  Test.assertEquals(tripledouble(10560002, 100), 1);
  Test.assertEquals(tripledouble(1112, 122), 0);
});