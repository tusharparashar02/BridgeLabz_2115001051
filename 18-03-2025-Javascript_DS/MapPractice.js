// 1. Write a program in the following steps
// a. Roll a die and find the number between 1 to 6
// b. Repeat the Die roll and find the result each time
// c. Store the result in a dictionary
// d. Repeat till any one of the number has reached 10 times
// e. Find the number that reached maximum times and the one that was for
// minimum times

function rollDie() {
    return Math.floor(Math.random() * 6) + 1; 
}

let dieMap = new Map();
let maxCount = 10;

// Initialize map with values from 1 to 6
for (let i = 1; i <= 6; i++) {
    dieMap.set(i, 0);
}

// Roll the die until any number reaches maxCount
let reachedMax = false;
while (!reachedMax) {
    let result = rollDie();
    dieMap.set(result, dieMap.get(result) + 1);
    if (dieMap.get(result) === maxCount) {
        reachedMax = true;
    }
}

// Finding the number with max and min occurrences
let maxNum = [...dieMap.entries()].reduce((a, b) => (a[1] > b[1] ? a : b))[0];
let minNum = [...dieMap.entries()].reduce((a, b) => (a[1] < b[1] ? a : b))[0];

console.log("Final Die Roll Counts:", Object.fromEntries(dieMap));
console.log("Number that appeared maximum times:", maxNum);
console.log("Number that appeared minimum times:", minNum);

//2  Write a Program to generate a birth month of 50 individuals
// between the year 92 & 93. Find all the individuals having birthdays
// in the same month. Store it to finally print.

function getRandomMonth() {
    return Math.floor(Math.random() * 12) + 1; 
}
let birthMonths = new Map();

// Initialize map with empty arrays for each month
for (let i = 1; i <= 12; i++) {
    birthMonths.set(i, []);
}

// Assign 50 individuals with random birth months
for (let i = 1; i <= 50; i++) {
    let month = getRandomMonth();
    birthMonths.get(month).push(i); 
}
// Print individuals having the same birth month
console.log("Individuals grouped by birth month:");
for (let [month, individuals] of birthMonths.entries()) {
    console.log(`Month ${month}: ${individuals.length > 0 ? individuals : "No individuals"}`);
}

