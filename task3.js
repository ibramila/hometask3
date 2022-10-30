//3 - Daxil olunan müsbət tam ədədin sadə və ya mürəkkəb olduğunu tapın

let number=6;
let numberOfDivisors=0;
for(let i=1; i<=number; i++){
    if(number%i==0){
        numberOfDivisors++;}
    }
if(numberOfDivisors<=2){console.log("it is a prime number");}
else{console.log("it is not prime number");}