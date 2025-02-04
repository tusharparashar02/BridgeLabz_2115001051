using System;

public class Patient
{
    public static string HospitalName = "City General Hospital";
    public static int TotalPatients = 0;
    public readonly string PatientID;
    public string Name { get; set; }
    public int Age { get; set; }
    public string Ailment { get; set; }
    public Patient(string name, int age, string ailment)
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = Guid.NewGuid().ToString();
        TotalPatients++;
    }

    public static int GetTotalPatients()
    {
        return TotalPatients;
    }
    public void DisplayPatientDetails()
    {
        Console.WriteLine("Hospital Name: " + HospitalName);
        Console.WriteLine("Patient Name: " + Name);
        Console.WriteLine("Patient Age: " + Age);
        Console.WriteLine("Patient Ailment: " + Ailment);
        Console.WriteLine("Patient ID: " + PatientID);
    }
}
