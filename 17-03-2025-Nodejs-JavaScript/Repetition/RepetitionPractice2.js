// 1. Print table of powers of 2 up to 2^n till 256 is reached
let n = parseInt(process.argv[2]);
console.log("Powers of 2 up to 2^" + n + " (max 256):");
let i = 0;
while (i <= n && Math.pow(2, i) <= 256) {
    console.log("2^" + i + " = " + Math.pow(2, i));
    i++;
}

// 2. Find the Magic Number
const readline = require('readline-sync');
let low = 1, high = 100;
console.log("Think of a number between 1 and 100");
while (low < high) {
    let mid = Math.floor((low + high) / 2);
    let response = readline.question(`Is your number less than ${mid}? (yes/no): `);
    if (response.toLowerCase() === 'yes') {
        high = mid - 1;
    } else {
        low = mid;
    }
    if (low == high) break;
}
console.log("Your magic number is:", low);

// 3. Extend the Flip Coin problem till either Heads or Tails wins 11 times
let heads = 0, tails = 0;
while (heads < 11 && tails < 11) {
    let flip = Math.random() < 0.5 ? 'Heads' : 'Tails';
    console.log(flip);
    flip === 'Heads' ? heads++ : tails++;
}
console.log("Final Score - Heads:", heads, "Tails:", tails);

// 4. Gambler problem: Start with Rs 100, bet Re 1 until goal Rs 200 or broke
let money = 100, bets = 0, wins = 0;
while (money > 0 && money < 200) {
    bets++;
    if (Math.random() < 0.5) {
        money++;
        wins++;
    } else {
        money--;
    }
}
console.log("Final Money:", money, "Total Bets:", bets, "Wins:", wins);
