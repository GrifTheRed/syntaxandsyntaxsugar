//int answer = 4;
//string response;
//if (answer < 9)

//{
//    response = answer + " is less than nine";
//}
//else
//{
//    response = answer + " is great than or equal to nine";
//}

//Given the code above, change the code to implement:
//inferred typing
//string interpolation
//and the ternary operator

var answer = 4;
var response = "";
if ( (answer < 9)
{
    response = ($"{answer} is less than nine");
}
else
{
    response = $"{answer} is greater than nine";
}
var response2 = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
Console.WriteLine(response);



