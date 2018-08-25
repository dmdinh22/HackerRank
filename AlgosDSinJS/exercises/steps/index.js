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

############
EXAMPLE
############

function printNumber(n) {
	// base case - no more work to do
  if (n === 0) {
    return;
  }
  
  // do some amount of work
  // in this case, print out the number 'n'
  console.log(n);
  
  // call function again
  // **change argument in some fashion!**
  printNumber(n-1); // recursive step
}

printNumber(10);
*/

// ## SOLUTION 2 ##
// Recursive
function steps(n, row = 0, stair = '') {
  //base case
  if (n === row) {
    return;
  }

  // do some work - print out 'stair' -> ''
  if (n === stair.length) {
    console.log(stair);
    return steps(n, row + 1);
  }

  // change argument in some fashion
  if (stair.length <= row) {
    stair += '#';
  } else {
    stair += ' ';
  }

  // call function again
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
