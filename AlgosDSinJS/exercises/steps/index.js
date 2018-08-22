// --- Directions
// Write a function that accepts a positive number N.
// The function should console log a step shape
// with N levels using the # character.  Make sure the
// step has spaces on the right hand side!
// --- Examples
//   steps(2)
//       '# '
//       '##'
//   steps(3)
//       '#  '
//       '## '
//       '###'
//   steps(4)
//       '#   '
//       '##  '
//       '### '
//       '####'

// ## SOLUTION 1 ##
// Iterative
function steps(n) {
  // from 0 to n (iterate over rows)
  for (let row = 0; row < n; row++) {
    // create an empty string 'stair'
    let stair = '';
    // from 0 to n (iterate over columns)
    for (let col = 0; col < n; col++) {
      // IF current col <= current row
      if (col <= row) {
        // add # to 'stair'
        stair += '#';
        // ELSE
      } else {
        // add space to 'stair'
        stair += ' ';
      }
    }
    // console.log 'stair'
    console.log(stair);
  }
}

module.exports = steps;
