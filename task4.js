//4 - Ay(month) adı daxil edilir. Çıxışa hansı fəsil olduğunu yazdırsın (switch case ilə yazın)
let month = "March";
switch (month)
{
    case "December":
    case "January":
    case "February":
        Console.WriteLine("winter");
        break;
    case "March":
    case "April":
    case "May":
        Console.WriteLine("spring");
        break;
    case "June":
    case "July":
    case "August":
        Console.WriteLine("summer");
        break;
    case "September":
    case "October":
    case "November":
        Console.WriteLine("fall");
        break; }