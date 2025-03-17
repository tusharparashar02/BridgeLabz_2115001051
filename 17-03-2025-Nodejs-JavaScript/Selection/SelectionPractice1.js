// 1. Generate 5 random three-digit numbers and find the min and max values
let numbers = [];
for (let i = 0; i < 5; i++) {
    numbers.push(Math.floor(Math.random() * 900) + 100); // Generates number between 100 and 999
}
console.log("Generated Numbers:", numbers);
console.log("Minimum Value:", Math.min(...numbers));
console.log("Maximum Value:", Math.max(...numbers));

// 2. Check if the given day and month fall between March 20 and June 20
let day = parseInt(process.argv[2]); // Read from command line
let month = parseInt(process.argv[3]);
if ((month === 3 && day >= 20) || (month === 4) || (month === 5) || (month === 6 && day <= 20)) {
    console.log("True - The date is within the range.");
} else {
    console.log("False - The date is outside the range.");
}

// 3. Check if a given year is a leap year
let year = parseInt(process.argv[4]); // Read from command line
if (year >= 1000 && year <= 9999) {
    if ((year % 4 === 0 && year % 100 !== 0) || (year % 400 === 0)) {
        console.log(year + " is a Leap Year.");
    } else {
        console.log(year + " is not a Leap Year.");
    }
} else {
    console.log("Please enter a valid 4-digit year.");
}

// 4. Simulate a coin flip and print "Heads" or "Tails"
let coinFlip = Math.random() < 0.5 ? "Heads" : "Tails";
console.log("Coin Flip Result:", coinFlip);
