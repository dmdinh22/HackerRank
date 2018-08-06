// --- Directions
// Given a string, return a new string with the reversed
// order of characters
// --- Examples
//   reverse('apple') === 'leppa'
//   reverse('hello') === 'olleh'
//   reverse('Greetings!') === '!sgniteerG'

// ## SOLUTION 2 ##
function reverse(str) {
  // create empty string called 'reversed'
  let reversed = '';

  // for each char in string
  for (let char of str) {
    //take char and add it to start of 'reversed' var
    reversed = char + reversed;
  }

  // return var 'reversed
  return reversed;
}

// ## SOLUTION 1 ##
/*
function reverse(str) {
  // // turn str into array
  // const arr = str.split('');

  // // reverse array
  // arr.reverse();

  // // join back into string
  // return arr.join('');

  // one liner for code cleanup
  return str
    .split('')
    .reverse()
    .join('');
}
*/

module.exports = reverse;
