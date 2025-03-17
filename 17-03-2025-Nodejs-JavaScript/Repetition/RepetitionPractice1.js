// 1. Print table of powers of 2 up to 2^n
let n = parseInt(process.argv[2]);
console.log("Powers of 2 up to 2^" + n + ":");
for (let i = 0; i <= n; i++) {
    console.log("2^" + i + " = " + Math.pow(2, i));
}

// 2. Compute the nth harmonic number
let harmonic = 0;
for (let i = 1; i <= n; i++) {
    harmonic += 1 / i;
}
console.log(n + "th Harmonic Number:", harmonic);

// 3. Check if a number is prime
let num = parseInt(process.argv[3]);
let isPrime = num > 1;
for (let i = 2; i * i <= num; i++) {
    if (num % i === 0) {
        isPrime = false;
        break;
    }
}
console.log(num + " is" + (isPrime ? " a Prime Number" : " not a Prime Number"));

// 4. Find prime numbers in a given range
let start = parseInt(process.argv[4]);
let end = parseInt(process.argv[5]);
console.log("Prime numbers between", start, "and", end, ":");
for (let i = start; i <= end; i++) {
    let prime = i > 1;
    for (let j = 2; j * j <= i; j++) {
        if (i % j === 0) {
            prime = false;
            break;
        }
    }
    if (prime) console.log(i);
}

// 5. Compute factorial of a number
let factNum = parseInt(process.argv[6]);
let factorial = 1;
for (let i = 1; i <= factNum; i++) {
    factorial *= i;
}
console.log("Factorial of", factNum, "is", factorial);

// 6. Compute prime factors of a number
let factorNum = parseInt(process.argv[7]);
console.log("Prime factors of", factorNum, ":");
for (let i = 2; i * i <= factorNum; i++) {
    while (factorNum % i === 0) {
        console.log(i);
        factorNum /= i;
    }
}
if (factorNum > 1) console.log(factorNum);
