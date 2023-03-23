/*
You've just finished writing the last chapter for your novel when a virus suddenly infects your document. 
It has swapped the 'i's and 'e's in 'ei' words and capitalised random letters. 
Write a function which will:
a) remove the spelling errors in 'ei' words. (Example of 'ei' words: their, caffeine, deceive, weight)
b) only capitalise the first letter of each sentence. Make sure the rest of the sentence is in lower case.
Example: He haD iEght ShOTs of CAffIEne. --> He had eight shots of caffeine.
*/

function proofread(str) {
  const array = str.toLowerCase().split(" ");
  let modified = "";

  const regexItem = /(?:[.:?!]\s[a-z]|^(?:\s+)?[a-z])/gm;

  for (const c of array) {
    if (c.includes("ie")) {
      modified += c.replace("ie", "ei") + " ";
    } else {
      modified += c + " ";
    }
  }

  return modified.replace(regexItem, (match) => match.toUpperCase()).trim();
}

proofread("ShE deCIeved HiM.");

const Test = require("@codewars/test-compat");

describe("proofread", function () {
  it("proofread", function () {
    Test.assertEquals(
      proofread("ThiEr DEcIEt wAs INconcIEVablE. sHe SIeZeD thE moMENT."),
      "Their deceit was inconceivable. She seized the moment."
    );
    Test.assertEquals(
      proofread("HIs nieghBOur wAs oVerwieGht."),
      "His neighbour was overweight."
    );
    Test.assertEquals(
      proofread("SHe rEcieveD a pIegNor."),
      "She received a peignor."
    );
  });
});
