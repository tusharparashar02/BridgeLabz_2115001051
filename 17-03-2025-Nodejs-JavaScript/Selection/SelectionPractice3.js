// 1. Read a single digit number and write the number in words using case
let num = parseInt(process.argv[2]);
switch (num) {
    case 0: console.log("Zero"); break;
    case 1: console.log("One"); break;
    case 2: console.log("Two"); break;
    case 3: console.log("Three"); break;
    case 4: console.log("Four"); break;
    case 5: console.log("Five"); break;
    case 6: console.log("Six"); break;
    case 7: console.log("Seven"); break;
    case 8: console.log("Eight"); break;
    case 9: console.log("Nine"); break;
    default: console.log("Invalid Input");
}

// 2. Read a number and display the weekday using case
let dayNumber = parseInt(process.argv[3]);
switch (dayNumber) {
    case 1: console.log("Sunday"); break;
    case 2: console.log("Monday"); break;
    case 3: console.log("Tuesday"); break;
    case 4: console.log("Wednesday"); break;
    case 5: console.log("Thursday"); break;
    case 6: console.log("Friday"); break;
    case 7: console.log("Saturday"); break;
    default: console.log("Invalid Day Number");
}

// 3. Read a number and display unit, ten, hundred, etc. using case
let unitNumber = parseInt(process.argv[4]);
switch (unitNumber) {
    case 1: console.log("Unit"); break;
    case 10: console.log("Ten"); break;
    case 100: console.log("Hundred"); break;
    case 1000: console.log("Thousand"); break;
    case 10000: console.log("Ten Thousand"); break;
    default: console.log("Invalid Input");
}

// 4. Unit Conversion based on user input
let conversionType = parseInt(process.argv[5]);
let value = parseFloat(process.argv[6]);
switch (conversionType) {
    case 1: console.log(value + " Feet = " + (value * 12) + " Inches"); break;
    case 2: console.log(value + " Feet = " + (value * 0.3048) + " Meters"); break;
    case 3: console.log(value + " Inches = " + (value / 12) + " Feet"); break;
    case 4: console.log(value + " Meters = " + (value / 0.3048) + " Feet"); break;
    default: console.log("Invalid Conversion Type");
}
