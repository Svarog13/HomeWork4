Console.WriteLine("Entered 6 digit number: ");
int digit = int.Parse(Console.ReadLine());

if (digit < 100000 || digit > 999999)
{
    Console.WriteLine("Error, you entered wrong digit");
}
else
{
    string reversedDigit = new string(digit.ToString().Reverse().ToArray());
    Console.WriteLine($"Hello motherfacker, we have new digit: {reversedDigit}");
}