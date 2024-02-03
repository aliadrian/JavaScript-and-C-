/* 
Instructions
You are given a secret message you need to decipher. Here are the things you need to know to decipher it:

For each word:

the second and the last letter is switched (e.g. Hello becomes Holle)
the first letter is replaced by its character code (e.g. H becomes 72)
Note: there are no special characters used, only letters and spaces

Examples

decipherThis('72olle 103doo 100ya'); // 'Hello good day'
decipherThis('82yade 115te 103o'); // 'Ready set go'
*/

function decipherThis(str) {
  let sb = "";
  let words = str.split(" ");
  if (str.length > 0) {
    words.forEach(function (word) {
      let resultString = word.match(/\d+/)[0];
      let i = parseInt(resultString);
      let converted = String.fromCharCode(i);

      let newString = word.substring(resultString.length);
      let result = converted + newString;

      if (result.length > 1) {
        let charArray = result.split("");
        let temp = charArray[1];
        charArray[1] = charArray[result.length - 1];
        charArray[result.length - 1] = temp;
        result = charArray.join("");
      }

      sb += result;
      sb += " ";
    });
  } else {
    return "";
  }

  return sb.trim();
}

describe("Tests", () => {
  it("test", () => {
    Test.assertEquals(
      decipherThis("72eva 97 103o 97t 116sih 97dn 115ee 104wo 121uo 100o"),
      "Have a go at this and see how you do"
    );
  });
});
