using System.Globalization;

int students = int.Parse(Console.ReadLine());

double topStudents = 0;
double veryGood = 0;
double good = 0;
double fail = 0;
double allGrades = 0;



for (int i = 1; i <= students; i++)
{ 
    double grade = double.Parse(Console.ReadLine());
    allGrades += grade;

    if (grade >= 2.00 && grade <= 2.99)
    {
        fail++;
    }
    if (grade >= 3.00 && grade <= 3.99)
    {
        good++;
    }
    if (grade >= 4.00 && grade <= 4.99)
    {
        veryGood++;
    }
    if (grade >= 5.00)
    {
        topStudents++;
    }
}

double topPercent = topStudents / students * 100;
double veryGoodPercent = veryGood / students * 100;
double goodPercent = good / students * 100;
double failPercent = fail / students * 100;
double allgradesPercent = allGrades / students;

Console.WriteLine($"Top students: {topPercent:f2}%");
Console.WriteLine($"Between 4.00 and 4.99: {veryGoodPercent:f2}%");
Console.WriteLine($"Between 3.00 and 3.99: {goodPercent:f2}%");
Console.WriteLine($"Fail: {failPercent:f2}%");
Console.WriteLine($"Average: {allgradesPercent:f2}");