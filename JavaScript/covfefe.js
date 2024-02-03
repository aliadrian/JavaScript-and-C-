// Instructions
// Your are given a string. You must replace any occurence of the sequence coverage by covfefe, however, if you don't find the word coverage in the string, you must add covfefe at the end of the string with a leading space.

function covfefe(str) {
  if (str.includes("coverage")) {
    let words = str.split(" ");
    let manyString = "";
    let covfefe = "covfefe";
    for (let i = 0; i < words.length; i++) {
      manyString += words[i].replace(/coverage/g, covfefe) + " ";
    }
    return manyString.trim();
  } else {
    return str + " covfefe";
  }
}

describe("Example tests", function () {
  Test.assertEquals(covfefe("coverage"), "covfefe");
  Test.assertEquals(covfefe("coverage coverage"), "covfefe covfefe");
  Test.assertEquals(covfefe("nothing"), "nothing covfefe");
  Test.assertEquals(covfefe("double space "), "double space  covfefe");
  Test.assertEquals(covfefe("covfefe"), "covfefe covfefe");
});
