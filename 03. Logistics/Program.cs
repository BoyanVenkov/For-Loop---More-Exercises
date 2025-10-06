int cargo = int.Parse(Console.ReadLine());

double vanCargo = 0;
double truckCargo = 0;
double trainCargo = 0;
double allCargo = 0;

for (int i =1; i <= cargo; i++)
{
    int tonsPerCargo = int.Parse(Console.ReadLine());


    if (tonsPerCargo <= 3)
    {
        vanCargo+= tonsPerCargo;
    }
    else if (tonsPerCargo >= 4 && tonsPerCargo <= 11)
    {
        truckCargo+=tonsPerCargo;
    }
    else if (tonsPerCargo >= 12)
    {
        trainCargo+=tonsPerCargo;
    }

}
allCargo = vanCargo + truckCargo + trainCargo;
double allCargoPrice = vanCargo * 200 + truckCargo * 175 + trainCargo * 120;
double allCargoPercent = allCargoPrice / allCargo;
double vanAverage = vanCargo / allCargo * 100;
double truckAverage = truckCargo / allCargo * 100;
double trainAverage = trainCargo /  allCargo * 100;


Console.WriteLine($"{allCargoPercent:f2}");
Console.WriteLine($"{vanAverage:f2}%");
Console.WriteLine($"{truckAverage:f2}%");
Console.WriteLine($"{trainAverage:f2}%");
