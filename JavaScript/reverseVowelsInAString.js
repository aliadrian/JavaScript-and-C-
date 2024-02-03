/*
  "Hello!" => "Holle!"
  "Tomatoes" => "Temotaos"
  "Reverse Vowels In A String" => "RivArsI Vewols en e Streng"
*/

function reverseVowels(str) {
  var regex = /[aeiouAEIOU]/;
  var vowels = [];
  var newString = '';

  for (var i = 0; i < str.length; i++) {
    var c = str[i];
    if (regex.test(c)) {
      vowels.push(c);
    }
  }

  vowels.reverse();
  var i = 0;

  for (var j = 0; j < str.length; j++) {
    var c = str[j];
    if (regex.test(c)) {
      newString += vowels[i];
      i++;
    } else {
      newString += c;
    }
  }

  return newString;
}

const chai = require("chai");
const assert = chai.assert;
chai.config.truncateThreshold = 0;

describe("Sample Tests", () => {
  it("test", () => {
    assert.strictEqual(reverseVowels("Hello!"), "Holle!");
    assert.strictEqual(reverseVowels("Tomatoes"), "Temotaos");
    assert.strictEqual(reverseVowels("Reverse Vowels In A String"), "RivArsI Vewols en e Streng");
  });
});