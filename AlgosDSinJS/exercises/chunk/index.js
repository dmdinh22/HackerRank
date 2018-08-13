// --- Directions
// Given an array and chunk size, divide the array into many subarrays
// where each subarray is of length size
// --- Examples
// chunk([1, 2, 3, 4], 2) --> [[ 1, 2], [3, 4]]
// chunk([1, 2, 3, 4, 5], 2) --> [[ 1, 2], [3, 4], [5]]
// chunk([1, 2, 3, 4, 5, 6, 7, 8], 3) --> [[ 1, 2, 3], [4, 5, 6], [7, 8]]
// chunk([1, 2, 3, 4, 5], 4) --> [[ 1, 2, 3, 4], [5]]
// chunk([1, 2, 3, 4, 5], 10) --> [[ 1, 2, 3, 4, 5]]

// ## SOLUTION 2 ##
function chunk(array, size) {
  const chunked = [];
  let index = 0;

  // as long as index < original length
  while (index < array.length) {
    //                slice from index to index plus size
    // array.slice() produces an array that contains some number of elements
    // out of the original array - take sliced array and stick into chunked array
    // with push method
    chunked.push(array.slice(index, index + size));

    // move onto next index - increment by size variable
    index += size;
  }

  return chunked;
}

// ## SOLUTION 1 ##
/*
function chunk(array, size) {
  // create empty array to hold chunks called 'chunked'
  const chunked = [];
  // for each element in 'unchunked' array
  for (let element of array) {
    // retrieve last element in 'chunked'
    const last = chunked[chunked.length - 1];
    // IF last element DNE, or if length = chunk size
    if (!last || last.length === size) {
      // push new chunk into 'chunked' w/ current element
      chunked.push([element]);

      // ELSE add current element into chunk
    } else {
      last.push(element);
    }
  }

  return chunked;
}
*/
module.exports = chunk;
