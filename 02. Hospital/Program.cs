int days = int.Parse(Console.ReadLine());
int doctors = 7;
int daysInHospital = 1;
int patientsExamined = 0;
int patientsUnExamined = 0;



for (int i = 1; i<= days; i++)
{
    int patients = int.Parse(Console.ReadLine());

    if (i % 3 == 0 && doctors <= patientsUnExamined)
    {
        doctors++;
    }
    if (doctors >= patients)
    {
        patientsExamined += patients;
    }
    if (patients > doctors)
    {
        patientsUnExamined += patients - doctors;
        patientsExamined += doctors;
    }
    daysInHospital++;

}
Console.WriteLine($"Treated patients: {patientsExamined}.");
Console.WriteLine($"Untreated patients: {patientsUnExamined}.");