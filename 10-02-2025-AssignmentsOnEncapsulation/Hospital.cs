using System;
using System.Collections.Generic;

abstract class Patient
{
    protected int patientId;
    
    protected string name;
    
    protected int age;

    public int PatientId { get { return patientId; } set { patientId = value; } }
    
    public string Name { get { return name; } set { name = value; } }
    
    public int Age { get { return age; } set { age = value; } }

    public Patient(int id, string n, int a)
    {
        patientId = id;
        name = n;
        age = a;
    }

    public abstract double CalculateBill();

    public void GetPatientDetails()
    {
        Console.WriteLine("Patient ID: " + patientId + ", Name: " + name + ", Age: " + age);
    }
}

interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

class InPatient : Patient, IMedicalRecord
{
    private double dailyRate;
    
    private int daysAdmitted;
    
    private List<string> records = new List<string>();

    public InPatient(int id, string n, int a, double rate, int days) : base(id, n, a)
    {
        dailyRate = rate;
        daysAdmitted = days;
    }

    public override double CalculateBill()
    {
        return dailyRate * daysAdmitted;
    }

    public void AddRecord(string record)
    {
        records.Add(record);
    }

    public void ViewRecords()
    {
        Console.WriteLine("Medical Records for " + name + ":");
        
        foreach (var rec in records)
        {
            Console.WriteLine(rec);
        }
    }
}

class OutPatient : Patient
{
    private double consultationFee;

    public OutPatient(int id, string n, int a, double fee) : base(id, n, a)
    {
        consultationFee = fee;
    }

    public override double CalculateBill()
    {
        return consultationFee;
    }
}

class Program
{
    static void Main()
    {
        List<Patient> patients = new List<Patient>();
        patients.Add(new InPatient(101, "Tushar", 89, 500, 7));
        
        patients.Add(new OutPatient(102, "Parashar", 70, 700));

        foreach (Patient pat in patients)
        {
            pat.GetPatientDetails();
            
            Console.WriteLine("Total Bill: " + pat.CalculateBill() + "\n");
        }
    }
}