// --- Directions
// Check to see if two provided strings are anagrams of eachother.
// One string is an anagram of another if it uses the same characters
// in the same quantity. Only consider characters, not spaces
// or punctuation.  Consider capital letters to be the same as lower case
// --- Examples
//   anagrams('rail safety', 'fairy tales') --> True
//   anagrams('RAIL! SAFETY!', 'fairy tales') --> True
//   anagrams('Hi there', 'Bye there') --> False

// ## SOLUTION 2 ##
function anagrams(stringA, stringB) {
  //      check if it's equal (including type)
  return cleanString(stringA) === cleanString(stringB);
}

// helper function
cleanString = str => {
  return (
    str
      //.replace(/[^\w]/g, '') // clean string of spaces and non chars
      .replace(/[^[a-zA-Z0-9]]/g, '')
      .toLowerCase()
      .split('') // turn into array
      .sort() // alphabetize
      .join('')
  ); // put back into array
};

// ## SOLUTION 1 ##
// function anagrams(stringA, stringB) {
//   // build char maps for strA and strB
//   const charMapA = buildCharMap(stringA);
//   const charMapB = buildCharMap(stringB);

//   // EDGE CASE - which string is longer by checking # of keys
//   if (Object.keys(charMapA).length !== Object.keys(charMapB).length) {
//     return false;
//   }

//   // use FOR - IN when iterating over object
//   for (let char in charMapA) {
//     // check if the keys match
//     if (charMapA[char] !== charMapB[char]) {
//       return false;
//     }
//   }

//   return true;
// }

// // helper function to build char map
// buildCharMap = str => {
//   const charMap = {};

//   // iterate over str with regex cleanup
//   for (let char of str.replace(/[^\w]/g).toLowerCase()) {
//     // set charMap key as the current char we're on
//     charMap[char] = charMap[char]++ /* + 1 */ || 1;
//   }

//   return charMap;
// };

module.exports = anagrams;
