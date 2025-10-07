int months = int.Parse(Console.ReadLine());
double elBill = 0;
double others = 0;
double allExpences = 0;

for (int i = 1; i <= months; i++)
{ 
    double bill = double.Parse(Console.ReadLine());
    others += (20 + 15 + bill) * 1.2;
    elBill += bill;

}
allExpences = elBill + others + 20 * months + 15 * months;
Console.WriteLine($"Electricity: {elBill:f2} lv");
Console.WriteLine($"Water: {20 * months:f2} lv");
Console.WriteLine($"Internet: {15 * months:f2} lv");
Console.WriteLine($"Other: {others:f2} lv");
Console.WriteLine($"Average: {allExpences / months:f2} lv"
);