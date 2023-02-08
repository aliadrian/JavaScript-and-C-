var str = "Hi my name is Ali";
const words = str.split(" ");
const covfefe = "covfefe";
const manyStrings = words[0];

for (let i = 0; i < words.length; i++) {
  manyStrings += words[i].replace(str, covfefe);
}

return manyStrings;
