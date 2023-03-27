/*
"camelsHaveThreeHumps"  -->  "camels-have-three-humps"
"camelsHave3Humps"  -->  "camels-have-humps"
"CAMEL"  -->  "c-a-m-e-l"
*/

// my solution
function kebabize(str) {
  const newString = str.replace(/\d/g, "");
  const split = newString.split(/(?<!^)(?=[A-Z])/);
  let camelCased = "";

  for (let i = 0; i < split.length; i++) {
    camelCased += split[i] + "-";
  }

  return camelCased.substring(0, camelCased.length - 1).toLowerCase();
}

// better solution
function kebabize(str) {
  var nonumber = str.replace(/\d/g, "").split(/(?=[A-Z])/g);
  return nonumber.join("-").toLowerCase();
}

describe("tests", () => {
  it("fixed tests", () => {
    Test.assertEquals(kebabize("myCamelCasedString"), "my-camel-cased-string");
    Test.assertEquals(kebabize("myCamelHas3Humps"), "my-camel-has-humps");
  });
});
