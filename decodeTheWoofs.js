/* Instructions
Justin has an exceptionally smart dog. In the latest show of its unparalleled intelligence, the dog learned to communicate human words. To do that, it woofs the exact number of times it takes to get to the right letter in the English alphabet. For example, if the dog is interested in the letter "A", it woofs just one time, if it's "B", it woofs two times and so on. Justin is amazed by his pet, but he also finds it challenging to translate the woofs in his head. Write a decoder for him that takes a string of hyphen-separated woofs and returns their human-language representation

Things to keep in mind:
Each valid woof sequence stands for one letter. All of them are guaranteed to end with an exclamation point. A space, on the other hand, is not guaranteed to follow

Justin's audio recorder is not a very good one. Sometimes, it inserts some random sounds that should be ignored. With that in mind, a woof is any sequence of letters that has a "w", an "o", another "o", and an "f" – in that order but not necessarily consecutively and irrespective of the case. If a string has no valid woof sequences, the method should return "nothing to decode!"

Each woof subsequence can contain either zero or one woof (which, in turn, represents zero or one step in the alphabet traversing). For example, in a woof sequence "Woof-shhh-woofwoof!" there are three subsequences: "Woof", "shhh", and "woofwoof". The first one contains a woof, the second one doesn't, the third one also has a woof (not two). It means this woof sequence of two woofs in total stands for "b"

Albeit a smart one, Justin's dog is still a dog. Sometimes, it just wants to bark! If the number of woofs in any woof sequence exceeds the number of letters in the English alphabet, you should return "just barking!"

Justin's dog has not yet learned the concept of spaces. The strings may represent more than one human word, but the returned string should not contain any white space characters

While input strings may contain letters of either case, the returned strings should be always in lower case

Examples:
"Woof-woof-woof-woof-woof-woof-woof-woof! Woof-woof-woof-woof-woof-woof-woof-woof-woof!" → "hi"
"Woof-woof-woof-woof-woof-woof!Woof-woof-woof-woof-woof! Woof-woof-woof-woof-woof! Woof-woof-woof-woof! Woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof! Woof-woof-woof-woof-woof!" → "feedme"
"Woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof!" → "just barking!"
"Shhhh!" → "nothing to decode!"
"WoofWoof!" → "a"
"Shhhhwoof!" → "a"
"Woofshhh! Shhh!" → "a"
"Wofowof!" → "a"
"khkhkhWbzzzzobzzzOghrrrrfseswsw!" → "a"
*/

function woofDecoder(str) {
  let newWord = str.split("!");
  let alphabet = [
    "a",
    "b",
    "c",
    "d",
    "e",
    "f",
    "g",
    "h",
    "i",
    "j",
    "k",
    "l",
    "m",
    "n",
    "o",
    "p",
    "q",
    "r",
    "s",
    "t",
    "u",
    "v",
    "w",
    "x",
    "y",
    "z",
  ];
  let dogSays = " ";
  let x = 0;

  for (let i = 0; i < newWord.length - 1; i++) {
    x = newWord[i].split("-").length;
  }

  if (x < alphabet.length) {
    for (let i = 0; i < newWord.length; i++) {
      if (
        newWord[i].toLowerCase().includes("w") &&
        newWord[i].toLowerCase().includes("o") &&
        newWord[i].toLowerCase().includes("f")
      ) {
        let z = newWord[i].split("-").length;
        let letter = alphabet[z - 1];
        dogSays += letter;
      } else if (
        !str.includes("w") &&
        !str.includes("o") &&
        !str.includes("f")
      ) {
        return "nothing to decode!";
      } else if (dogSays === "" || dogSays.length <= 0) {
        return "nothing to decode!";
      }
    }
  } else if (x > alphabet.length) {
    return "just barking!";
  }

  return dogSays.trim();
}

const chai = require("chai");
const assert = chai.assert;
chai.config.truncateThreshold = 0;

describe("woofDecoderSampleTests", function () {
  it(
    'given "Woof-woof-woof-woof-woof-woof-woof-' +
      'woof! Woof-woof-woof-woof-woof-woof-woof-woof-woof!"',
    function () {
      assert.deepEqual(
        woofDecoder(
          "Woof-woof-woof-woof-woof-woof-woof-" +
            "woof! Woof-woof-woof-woof-woof-woof-woof-woof-woof!"
        ),
        "hi"
      );
    }
  );

  it('given "feedme"', function () {
    assert.deepEqual(
      woofDecoder(
        "Woof-woof-woof-woof-woof-woof!Woof-woof-woof-woof-woof! " +
          "Woof-woof-woof-woof-woof! Woof-woof-woof-woof! " +
          "Woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof-woof! " +
          "Woof-woof-woof-woof-woof!"
      ),
      "feedme"
    );
  });

  it('given "Woof! Woof" + "-woof".repeat(26) + "!"', function () {
    assert.deepEqual(
      woofDecoder("Woof! Woof" + "-woof".repeat(26) + "!"),
      "just barking!"
    );
  });

  it('given "Shhhh!"', function () {
    assert.deepEqual(woofDecoder("Shhhh!"), "nothing to decode!");
  });

  it('given "WoofWoof!"', function () {
    assert.deepEqual(woofDecoder("WoofWoof!"), "a");
  });

  it('given "Shhhhwoof!"', function () {
    assert.deepEqual(woofDecoder("Shhhhwoof!"), "a");
  });

  it('given "Woofshhh! Shhh!"', function () {
    assert.deepEqual(woofDecoder("Woofshhh! Shhh!"), "a");
  });

  it('given "Wofowof!"', function () {
    assert.deepEqual(woofDecoder("Wofowof!"), "a");
  });

  it('given "khkhkhWbzzzzobzzzOghrrrrfseswsw!"', function () {
    assert.deepEqual(woofDecoder("khkhkhWbzzzzobzzzOghrrrrfseswsw!"), "a");
  });
});
