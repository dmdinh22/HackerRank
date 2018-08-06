// --- Directions
// Given a string, return a new string with the reversed
// order of characters
// --- Examples
//   reverse('apple') === 'leppa'
//   reverse('hello') === 'olleh'
//   reverse('Greetings!') === '!sgniteerG'

function reverse(str) {
  // turn str into array
  const arr = str.split('');

  // reverse array
  arr.reverse();

  // join back into string
  return arr.join('');
}

module.exports = reverse;
