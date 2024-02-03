// Incorrect version
function getSumOfDigits(integer) {
  var sum = null;
  var digits = Math.floor(integer).toString();
  for (var ix = 1; ix < digits.length; ix = sum + 1) {
    // sum =+ digits[ix + 1]);
  }
  return sum;
}

// Correct version
function getSumOfDigits(integer) {
  var sum = 0;
  var digits = Math.floor(integer).toString();
  for (var i = 0; i < digits.length; i++) {
    sum += parseInt(digits[i]);
  }
  return sum;
}

// Another correct version
function getSumOfDigits(integer) {
  var sum = null;
  var digits = Math.floor(integer).toString();
  for (var ix = 0; ix < digits.length; ix++) {
    sum += +digits[ix];
  }
  return sum;
}
