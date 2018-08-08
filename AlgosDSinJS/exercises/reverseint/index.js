// --- Directions
// Given an integer, return an integer that is the reverse
// ordering of numbers.
// --- Examples
//   reverseInt(15) === 51
//   reverseInt(981) === 189
//   reverseInt(500) === 5
//   reverseInt(-15) === -51
//   reverseInt(-90) === -9

function reverseInt(n) {
  const reversed = n
    .toString() // convert int to string
    .split('') // split string into array
    .reverse() // reverse array els
    .join(''); // join back into string

  //             parse string to int
  return n < 0 ? parseInt(reversed) * -1 : parseInt(reversed);
}

module.exports = reverseInt;
