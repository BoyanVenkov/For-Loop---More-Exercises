int rounds = int.Parse(Console.ReadLine());

double result = 0;
double input09 = 0;
double input1019 = 0;
double input2029 = 0;
double input3039 = 0;
double input4050 = 0;
double input050 = 0;

for (int i = 1; i <= rounds; i++)
{
    double input = double.Parse(Console.ReadLine());

    if (input < 0 || input > 50)
    {
        result /= 2;
        input050++;
    }
    if (input >= 0 && input <= 9)
    {
        result += input * 0.2;
        input09++;
    }
    if (input >= 10 && input <= 19)
    {
        result += input * 0.3;
        input1019++;
    }
    if (input >= 20 && input <= 29)
    {
        result += input * 0.4;
        input2029++;
    }
    if (input >= 30 && input <= 39)
    {
        result += 50;
        input3039++;
    }
    if (input >= 40 && input <= 50)
    {
        result += 100;
        input4050++;
    }

}

Console.WriteLine($"{result:f2}");
Console.WriteLine($"From 0 to 9: {input09 / rounds * 100:f2}%");
Console.WriteLine($"From 10 to 19: {input1019 / rounds * 100:f2}%");
Console.WriteLine($"From 20 to 29: {input2029 / rounds * 100:f2}%");
Console.WriteLine($"From 30 to 39: {input3039 / rounds * 100:f2}%");
Console.WriteLine($"From 40 to 50: {input4050 / rounds * 100:f2}%");
Console.WriteLine($"Invalid numbers: {input050 / rounds * 100:f2}%");