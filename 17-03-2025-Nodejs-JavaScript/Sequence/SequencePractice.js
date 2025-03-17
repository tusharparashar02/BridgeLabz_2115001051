// 1. Generate a single digit random number
let singleDigit = Math.floor(Math.random() * 10);
console.log("Single Digit Random Number:", singleDigit);

// 2. Generate a random dice number between 1 to 6
let diceNumber = Math.floor(Math.random() * 6) + 1;
console.log("Random Dice Number:", diceNumber);

// 3. Add two random dice numbers and print the result
let dice1 = Math.floor(Math.random() * 6) + 1;
let dice2 = Math.floor(Math.random() * 6) + 1;
let diceSum = dice1 + dice2;
console.log("Dice 1:", dice1, "Dice 2:", dice2, "Sum:", diceSum);

// 4. Generate 5 random two-digit numbers, find their sum and average
let sum = 0;
for (let i = 0; i < 5; i++) {
    let randomTwoDigit = Math.floor(Math.random() * 90) + 10; 
    console.log("Generated Number", i + 1, ":", randomTwoDigit);
    sum += randomTwoDigit;
}
let average = sum / 5;
console.log("Sum of 5 random numbers:", sum);
console.log("Average of 5 random numbers:", average);

// 5. Unit Conversion
// a. Convert 42 inches to feet
let inches = 42;
let feet = inches / 12;
console.log("42 inches in feet:", feet);

// b. Convert rectangular plot of 60 feet x 40 feet to meters (1 ft = 0.3048 m)
let lengthFeet = 60;
let widthFeet = 40;
let lengthMeters = lengthFeet * 0.3048;
let widthMeters = widthFeet * 0.3048;
console.log("Rectangular plot in meters:", lengthMeters, "x", widthMeters);

// c. Calculate the area of 25 such plots in acres (1 acre = 4046.86 square meters)
let areaOnePlot = lengthMeters * widthMeters;
let totalArea = areaOnePlot * 25;
let totalAreaInAcres = totalArea / 4046.86;
console.log("Total area of 25 plots in acres:", totalAreaInAcres);
