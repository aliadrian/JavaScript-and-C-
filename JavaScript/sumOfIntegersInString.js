function sumOfIntegersInString(s) {
  let sum = 0;
  const matches = s.match(/\d+/g);

  if (matches) {
    for (let i = 0; i < matches.length; i++) {
      sum += parseInt(matches[i]);
    }
  }
  return sum;
}

// doesn't work
// Recover toString() here :)
// function toString(str) {
//   var numbers = /0-9/;
//   var PI = Math.PI;
//   var E = Math.E;
//   var boolTrue = Boolean(true);
//   var boolFalse = Boolean(false);
//   var arr = [];
//   if (str.includes(numbers)) {
//     return `"${numbers}"`;
//   } else if (str.includes(PI)) {
//     return `"${PI}"`;
//   } else if (str.includes(E)) {
//     return `"${E}"`;
//   } else if (str.includes(boolTrue)) {
//     return `"${true}"`;
//   } else if (str.includes(boolFalse)) {
//     return `"${false}"`;
//   } else if (str.includes(arr)) {
//     return `"${[]}"`;
//   }
// }
