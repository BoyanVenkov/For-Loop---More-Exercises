int pairs = int.Parse(Console.ReadLine());

int previousSum = 0;
int equalSum = 0;
int maxDiff = 0;
int diff = 0;
for (int i = 1; i <= pairs; i++)
{
    int firstNum = int.Parse(Console.ReadLine());
    int secondNum = int.Parse(Console.ReadLine());
    int currentSum = secondNum + firstNum;
    if (i == 1)
    {
        equalSum = currentSum;
        previousSum = currentSum;
    }
    else
    {
        diff = Math.Abs(currentSum - previousSum);
    }
       
    if (maxDiff < diff)
    {
        maxDiff = diff;
    }

  
    previousSum = currentSum;
}
if (maxDiff == 0)
{
    Console.WriteLine($"Yes, value={equalSum}");
}
else
{
    Console.WriteLine($"No, maxdiff={maxDiff}");
}