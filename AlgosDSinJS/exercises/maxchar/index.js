// --- Directions
// Given a string, return the character that is most
// commonly used in the string.
// --- Examples
// maxChar("abcccccccd") === "c"
// maxChar("apple 1231111") === "1"

// Common String Questions Similar
/*
- What is the most common char in the string? 
- Does string A have the same chars as string B (is it an anagram)?
- Does the given string have any repeated chars in it?
*/

function maxChar(str) {
  const charMap = {};
  let max = 0;
  let maxChar = '';

  // create chars obj with character as key and amount as value
  for (let char of str) {
    !charMap[char] ? (charMap[char] = 1) : charMap[char]++;
  }

  // iterate over charMap and check against max value
  for (let char in charMap) {
    // for in - object iteration
    if (charMap[char] > max) {
      max = charMap[char];
      maxChar = char;
    }
  }

  return maxChar;
}

module.exports = maxChar;
