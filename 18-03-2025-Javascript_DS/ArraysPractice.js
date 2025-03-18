// 1. Write a program in the following steps
// a. Generates 10 Random 3 Digit number.
// b. Store this random numbers into a array.
// c. Then find the 2nd largest and the 2nd smallest element without sorting the array.
function generateRandomNumber() {
    return Math.floor(Math.random() * 900) + 100; // Random 3-digit number (100-999)
}

let numbers = [];
for (let i = 0; i < 10; i++) {
    numbers.push(generateRandomNumber());
}

console.log("Generated Numbers:", numbers);

function findSecondLargestAndSmallest(arr) {
    let largest = -Infinity, secondLargest = -Infinity;
    let smallest = Infinity, secondSmallest = Infinity;

    for (let num of arr) {
        if (num > largest) {
            secondLargest = largest;
            largest = num;
        } else if (num > secondLargest && num !== largest) {
            secondLargest = num;
        }

        if (num < smallest) {
            secondSmallest = smallest;
            smallest = num;
        } else if (num < secondSmallest && num !== smallest) {
            secondSmallest = num;
        }
    }

    return { secondLargest, secondSmallest };
}

let { secondLargest, secondSmallest } = findSecondLargestAndSmallest(numbers);
console.log("Second Largest:", secondLargest);
console.log("Second Smallest:", secondSmallest);

// 2. Extend the above program to sort the array and then find the 2nd largest

// and the 2nd smallest element.
let sortedNumbers = [...numbers].sort((a, b) => a - b);
console.log("Sorted Numbers:", sortedNumbers);

console.log("Second Smallest:", sortedNumbers[1]);
console.log("Second Largest:", sortedNumbers[sortedNumbers.length - 2]);

// 3. Extend the Prime Factorization Program to store all the Prime Factors of a

// number n into an array and finally display the output.

function getPrimeFactors(n) {
    let factors = [];
    while (n % 2 === 0) {
        factors.push(2);
        n /= 2;
    }

    for (let i = 3; i <= Math.sqrt(n); i += 2) {
        while (n % i === 0) {
            factors.push(i);
            n /= i;
        }
    }

    if (n > 2) {
        factors.push(n);
    }

    return factors;
}

let number = 84; // Change this to any number
let primeFactors = getPrimeFactors(number);
console.log(`Prime Factors of ${number}:`, primeFactors);

//4. Write a Program to show Sum of three Integer adds to ZERO
function findTriplets(arr) {
    let triplets = [];
    let n = arr.length;

    for (let i = 0; i < n - 2; i++) {
        for (let j = i + 1; j < n - 1; j++) {
            for (let k = j + 1; k < n; k++) {
                if (arr[i] + arr[j] + arr[k] === 0) {
                    triplets.push([arr[i], arr[j], arr[k]]);
                }
            }
        }
    }

    return triplets;
}

let inputArray = [-1, 0, 1, 2, -1, -4];
console.log("Triplets with sum zero:", findTriplets(inputArray));

//5. Take a range from 0 – 100, find the digits that are repeated twice like 33, 77,
//etc and store them in an array

function findRepeatedDigits() {
    let repeatedNumbers = [];

    for (let i = 10; i < 100; i++) {
        let strNum = i.toString();
        if (strNum[0] === strNum[1]) {
            repeatedNumbers.push(i);
        }
    }

    return repeatedNumbers;
}

console.log("Numbers with repeated digits:", findRepeatedDigits());



