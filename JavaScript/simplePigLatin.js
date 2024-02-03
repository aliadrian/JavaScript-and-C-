// EXACTLY THE SAME AS THE C-SHARP SOLUTION
// function pigIt(str) {
//   const words = str.split(" ");
//   let newString = "";

//   const charArray = str.split("").reverse().join("");

//   for (let i = 0; i < words.length; i++) {
//     const word = words[i];
//     const firstLetter = word.substring(0, 1);
//     const restOfWord = word.substring(1);

//     if (word.length > 1) {
//       newString += restOfWord + firstLetter + "ay" + " ";
//     } else {
//       newString += restOfWord + firstLetter;
//     }
//   }

//   return newString.trim();
// }

// MY SOLUTION
// MODIFIED TO PASS THE TEST ON CODEWARS 🤭
function pigIt(str) {
  const words = str.split(" ");
  let newString = "";

  const charArray = str.split("").reverse().join("");

  for (let i = 0; i < words.length; i++) {
    const word = words[i];
    const firstLetter = word.substring(0, 1);
    const restOfWord = word.substring(1);

    if (word.includes("!") || word.includes("?")) {
      newString += restOfWord + firstLetter;
    } else {
      newString += restOfWord + firstLetter + "ay" + " ";
    }
  }

  return newString.trim();
}

// BETTER SOLUTIONS
// function pigIt(str) {
//   return str.replace(/\w+/g, (w) => {
//     return w.slice(1) + w[0] + "ay";
//   });
// }

// function pigIt(str) {
//   var arrayWord = str.split(" ");
//   return arrayWord
//     .map(function (word) {
//       var firstLetter = word.charAt(0);
//       return word.slice(1) + firstLetter + "ay";
//     })
//     .join(" ");
// }

const Test = require("@codewars/test-compat");

describe("Tests", () => {
  it("test", () => {
    Test.assertEquals(pigIt("Pig latin is cool"), "igPay atinlay siay oolcay");
    Test.assertEquals(pigIt("This is my string"), "hisTay siay ymay tringsay");
  });
});
