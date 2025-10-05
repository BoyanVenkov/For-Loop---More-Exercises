double inheritance = double.Parse(Console.ReadLine());
double year = double.Parse(Console.ReadLine());

double oddMoney = 0;
double totalMoney = 0;
double age = 18;

for (int i = 1800; i<=year; i++)
{
    if (i % 2 == 0)
    {
        totalMoney += 12000;
        age++;
    }
    else
    {
        oddMoney = 12000 + 50 * age;
        totalMoney += oddMoney;
        age++;
    }
}
if (inheritance >= totalMoney)
{
    Console.WriteLine($"Yes! He will live a carefree life and will have {inheritance - totalMoney:f2} dollars left.");
}
else 
{
    Console.WriteLine($"He will need {totalMoney - inheritance:f2} dollars to survive.");
}