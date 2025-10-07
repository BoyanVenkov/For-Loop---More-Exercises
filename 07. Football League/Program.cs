double capacity = int.Parse(Console.ReadLine());
double fans = int.Parse(Console.ReadLine());

double secA = 0;
double secB = 0;
double secV = 0;
double secG = 0;

for (int i = 1; i <= fans; i++)
{ 
    char fan = char.Parse(Console.ReadLine());

    if (fan == 'A')
    {
        secA++;
    }
    else if (fan == 'B')
    {
        secB++;
    }
    else if (fan == 'V')
    {
        secV++;
    }
    else
    {
        secG++;
    }

}
Console.WriteLine($"{secA / fans * 100:f2}%");
Console.WriteLine($"{secB / fans * 100:f2}%");
Console.WriteLine($"{secV / fans * 100:f2}%");
Console.WriteLine($"{secG / fans * 100:f2}%");
Console.WriteLine($"{fans / capacity * 100:f2}%" );