// --- Directions
// Given a string, return true if the string is a palindrome
// or false if it is not.  Palindromes are strings that
// form the same word if it is reversed. *Do* include spaces
// and punctuation in determining if the string is a palindrome.
// --- Examples:
//   palindrome("abba") === true
//   palindrome("abcdefg") === false

// ## SOLUTION 2 ##
// using every array helper
function palindrome(str) {
  // turn str into array and then call every method on it
  return str.split('').every((char, i) => {
    return char === str[str.length - i - 1]; // -1 for 0 index
  });
}

// ## SOLUTION 1 ##
/*
function palindrome(str) {
  // reverse string
  const reversed = str
    .split('')
    .reverse()
    .join('');

  //produces boolean value
  return str === reversed;
}
*/

// ## My Solution ##
/*
function palindrome(str) {
  let reversedString = str
    .split('')
    .reverse()
    .join('');

  return str === reversedString ? true : false;
}
*/

module.exports = palindrome;
