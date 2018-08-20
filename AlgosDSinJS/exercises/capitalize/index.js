// --- Directions
// Write a function that accepts a string.  The function should
// capitalize the first letter of each word in the string then
// return the capitalized string.
// --- Examples
//   capitalize('a short sentence') --> 'A Short Sentence'
//   capitalize('a lazy fox') --> 'A Lazy Fox'
//   capitalize('look, it is working!') --> 'Look, It Is Working!'

function capitalize(str) {
  // create 'result' which is the first char of the input string capitalized
  let result = str[0].toUpperCase();
  // for each char in string
  for (let i = 1; i < str.length; i++) {
    // if char to left is a space
    if (str[i - 1] === ' ') {
      // uppercase and add to result
      result += str[i].toUpperCase();
      // else
    } else {
      // add char to 'result' as is
      result += str[i];
    }
  }

  return result;
}

// ## SOLUTION 1 ##
// using array helper methods
/*
function capitalize(str) {
  // make an empty array 'words'
  const words = [];
  // split input str by spaces to get an array
  //for each word in the array
  for (let word of str.split(' ')) {
    // capitalize first letter of word
    // join first letter w/ rest of str
    // push joined word into 'words' array
    words.push(word[0].toUpperCase() + word.slice(1));
  }
  // join 'words' into a string and return it
  return words.join(' ');
}
*/
module.exports = capitalize;
