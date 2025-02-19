using System;
using System.Collections.Generic;

class Patient
{
    public string Name { get; set; }
    public int Severity { get; set; }

    public Patient(string name, int severity)
    {
        Name = name;
        Severity = severity;
    }
}

class PatientComparer : IComparer<Patient>
{
    public int Compare(Patient x, Patient y)
    {
        return y.Severity.CompareTo(x.Severity); 
    }
}

class HospitalTriageSystem
{
    static void Main()
    {
        SortedSet<Patient> priorityQueue = new SortedSet<Patient>(new PatientComparer())
        {
            new Patient("Tushar", 3),
            new Patient("Parashar", 5),
            new Patient("GLA", 2)
        };

        Console.WriteLine("Order of Treatment:");
        foreach (var patient in priorityQueue)
            Console.WriteLine(patient.Name);
    }
}
