/**
 * @param {string[]} words
 * @return {string[]}
 */
var stringMatching = function(words) {
    let solution = []
    
    // compare each string with all other strings in words array
    for (let i=0; i <= words.length-1; ++i) {
        const chars1 = words[i].split("")
        console.log(chars1)
      let substring = ""
      for (let j=0; j < words.length; j++) {
        if (i !== j) {
        const chars2 = words[j].split("")
        
        
        
        if (chars1.length > chars2.length) {
            for (let x=0; x < chars2.length; x++) {
                if (chars1[x] === chars2[x]) {
                    substring.push(chars1)
                }
            }
        }
        else {
             for (let x=0; x < chars1.length; x++) {
                if (chars1[x] === chars2[x]) {
                    substring.push(chars1)
                }
            }
        }
        }
        solution.push(substring)
    }
    }
    return solution;
};
const test = ["mass","as","hero","superhero"]
console.log(stringMatching(test))