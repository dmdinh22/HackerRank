// find all anagrams from one string
function findAnagrams(string, anagram = '', anagrams = []) {
  // if string is empty
  if (!string) {
    anagrams.push(anagram);
    return;
  }

  //loop over string chars
  for (let i = 0; i < string.length; i++) {
    // recursively slice portions of string
    findAnagrams(
      string.slice(0, i) + string.slice(i + 1),
      anagram + string[i],
      anagrams
    );
  }

  return [...new Set(anagrams)];
}

console.log(findAnagrams('ABRACADABRA'));
