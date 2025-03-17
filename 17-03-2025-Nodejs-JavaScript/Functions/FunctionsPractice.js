// 1. Temperature Conversion using Case Statement
function convertTemperature(value, type) {
    switch (type) {
        case 'CtoF':
            return (value * 9/5) + 32;
        case 'FtoC':
            return (value - 32) * 5/9;
        default:
            return "Invalid Type";
    }
}

// 2. Check if two numbers are Palindromes
function isPalindrome(num) {
    let reversed = parseInt(num.toString().split('').reverse().join(''));
    return num === reversed;
}

// 3. Check if a number is prime
function isPrime(num) {
    if (num < 2) return false;
    for (let i = 2; i * i <= num; i++) {
        if (num % i === 0) return false;
    }
    return true;
}

// Check if the palindrome of a prime number is also prime
function checkPrimePalindrome(num) {
    if (isPrime(num)) {
        let pal = parseInt(num.toString().split('').reverse().join(''));
        console.log(`Palindrome of ${num} is ${pal}, which is ${isPrime(pal) ? "also Prime" : "not Prime"}`);
    } else {
        console.log(num + " is not a prime number.");
    }
}