int n = int.Parse(Console.ReadLine());

double evenSum = 0;
double oddSum = 0;
double evenMin = double.MaxValue;
double evenMax = double.MinValue;
double oddMin = double.MaxValue;
double oddMax = double.MinValue;

for (int i = 1; i <= n; i++)
{
    double input = double.Parse(Console.ReadLine());

    if (i % 2 == 0)
    {
        evenSum += input;
        if (input < evenMin)
        {
            evenMin = input;

        }
        if (input > evenMax)
        {
            evenMax = input;
        }
    }
    else 
    {
        oddSum += input;
        if (input < oddMin)
        {
            oddMin = input;
        }
        if (input > oddMax)
        {
            oddMax = input;
        }
    }

}
Console.WriteLine($"OddSum={oddSum:f2},");
if (oddMin == double.MaxValue)
{
    Console.WriteLine("OddMin=No,");
    Console.WriteLine("OddMax=No,");
}
else
{
    Console.WriteLine($"OddMin={oddMin:f2},");
    Console.WriteLine($"OddMax={oddMax:f2},");
}
Console.WriteLine($"EvenSum={evenSum:f2},");
if (evenMin == double.MaxValue)
{
    Console.WriteLine($"EvenMin=No,");
    Console.WriteLine($"EvenMax=No");
}
else
{
    Console.WriteLine($"EvenMin={evenMin:f2},");
    Console.WriteLine($"EvenMax={evenMax:f2}");
}



