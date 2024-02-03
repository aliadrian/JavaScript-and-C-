// my solution
var isSquare = function (n) {
  if (n >= 0 && Math.sqrt(n) % 1 === 0) {
    return true;
  } else {
    return false;
  }
};

// better solution
function isSquare(n) {
  return Math.sqrt(n) % 1 === 0;
}

// CONDITIONS
// should work for some examples
// should work for random square numbers
// should work for random numbers
