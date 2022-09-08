
//Task 19

string? number = Console.ReadLine();

void CheckingNumber(string number){
if (number[0]==number[4] && number[1]==number[3]){
Console.WriteLine("yes");
 }
  else Console.WriteLine("no");
}

if (number!.Length == 5){
CheckingNumber(number);
}
else Console.WriteLine("Wrong number");


