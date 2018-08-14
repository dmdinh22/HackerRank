// --- Directions
// Given a string, return a new string with the reversed
// order of characters
// --- Examples
//   reverse('apple') === 'leppa'
//   reverse('hello') === 'olleh'
//   reverse('Greetings!') === '!sgniteerG'

// ## SOLUTION 3 ##
// use reduce helper
/*
function reverse(str) {
  // turn str into array
  return (
    str
      .split('')
      // use reduce helper method
      // two args for reduce - arrow fn, starting arg value
      // two args for arrow fn - first arg is reversed string,
      // second is the element we're operating on
      .reduce((reversed, character) => {
        return character + reversed;
      }, '')
  ); // starting arg is empty string
}
*/

// ## SOLUTION 2 ##
function reverse(str) {
  // create empty string called 'reversed'
  let reversed = '';
  // for each char in string - new syntax (var X of arg)
  for (let char of str) {
    //take char and add it to start of 'reversed' var
    reversed = char + reversed;
    debugger;
  }
  // return var 'reversed
  return reversed;
}

// call the function to use the debugger;
reverse('asdf');

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

// ## SOLUTION ##
/*
function reverse(str) {
  let reversed = '';

  for (i = 0; i < str.length; i++) {
    reversed = str[i] + reversed;
  }

  return reversed;
}
*/

module.exports = reverse;
