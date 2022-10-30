//2 - Daxil edilən müsbət tam ədədin palindrom olub-olmamasını yoxlayın

let number = 121; //verilen ededimiz
let mod= 0;//ededin tersi
let foundNumber = 0; //tapdigimiz tersine olan eded
for (let i=number; i>=1; i=i/10)
{
    mod = i%10;
    foundNumber = mod + foundNumber;
    if (i>=10) {foundNumber = foundNumber * 10; }}
if (foundNumber == number) { console.log("It is a palindrom number"); }
else { console.log("It is not a palindrom number"); }