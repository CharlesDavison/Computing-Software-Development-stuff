Console.WriteLine("Enter the upper limit:");
string usrInput = Console.ReadLine();

int upperLimit;

while (!int.TryParse(usrInput, out upperLimit))
{
    Console.WriteLine("Enter a valid number:");
    usrInput = Console.ReadLine();
}

int sum = 0;

for (int i =1; i < upperLimit+1; i++)
{
    sum += i;
    Console.WriteLine(i + ": " + sum + "\n");
}
Console.WriteLine(sum);