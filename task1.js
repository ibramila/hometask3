//1 - Verilmiş ədədin ikinin qüvvəti olub olmadığını yoxlayan alqoritm yazın

let number = 4;
let foundNumber = 0;

for (let i = number; i>1; i=i/2) {
    foundNumber=i;
}

if (foundNumber/2==1) {
    console.log("it is power of 2");
    
}
else{
    console.log("it is not power of 2");
}