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

// Recursion Tips
/*
- figure out bare min pieces of info to represent your problem
- give reasonable defaults to bare min pieces of info
- check base case: any work left to do? if not, return
- do some work - call function again, amking sure the args have changed in some fashion
*/

// ## SOLUTION 2 ##
// Recursive
function steps(n, row = 0, stair = '') {
  //base case
  if (n === row) {
    return;
  }

  if (n === stair.length) {
    console.log(stair);
    return steps(n, row + 1);
  }

  if (stair.length <= row) {
    stair += '#';
  } else {
    stair += ' ';
  }

  steps(n, row, stair);
}

// ## SOLUTION 1 ##
// Iterative
/*
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
*/
module.exports = steps;
