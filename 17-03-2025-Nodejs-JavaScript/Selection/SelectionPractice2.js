// 1. Read a single digit number and write the number in words
let num = parseInt(process.argv[2]);
if (num === 0) console.log("Zero");
else if (num === 1) console.log("One");
else if (num === 2) console.log("Two");
else if (num === 3) console.log("Three");
else if (num === 4) console.log("Four");
else if (num === 5) console.log("Five");
else if (num === 6) console.log("Six");
else if (num === 7) console.log("Seven");
else if (num === 8) console.log("Eight");
else if (num === 9) console.log("Nine");
else console.log("Invalid Input");

// 2. Read a number and display the weekday
let dayNumber = parseInt(process.argv[3]);
if (dayNumber === 1) console.log("Sunday");
else if (dayNumber === 2) console.log("Monday");
else if (dayNumber === 3) console.log("Tuesday");
else if (dayNumber === 4) console.log("Wednesday");
else if (dayNumber === 5) console.log("Thursday");
else if (dayNumber === 6) console.log("Friday");
else if (dayNumber === 7) console.log("Saturday");
else console.log("Invalid Day Number");

// 3. Read a number and display unit, ten, hundred, etc.
let unitNumber = parseInt(process.argv[4]);
if (unitNumber === 1) console.log("Unit");
else if (unitNumber === 10) console.log("Ten");
else if (unitNumber === 100) console.log("Hundred");
else if (unitNumber === 1000) console.log("Thousand");
else if (unitNumber === 10000) console.log("Ten Thousand");
else console.log("Invalid Input");

// 4. Perform arithmetic operations and find the maximum and minimum
let a = parseInt(process.argv[5]);
let b = parseInt(process.argv[6]);
let c = parseInt(process.argv[7]);

let op1 = a + b * c;
let op2 = a % b + c;
let op3 = c + a / b;
let op4 = a * b + c;

console.log("Results:", { op1, op2, op3, op4 });

let maxVal = Math.max(op1, op2, op3, op4);
let minVal = Math.min(op1, op2, op3, op4);

console.log("Maximum Value:", maxVal);
console.log("Minimum Value:", minVal);