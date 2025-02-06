using System;
using System.Collections.Generic;

namespace Assignments{
    class Patient{
        public string Name { get; set; }
        public List<Doctor> Doctors { get; } = new List<Doctor>();
        public Patient(string name){
            Name = name;
        }
        public void ConsultDoctor(Doctor doctor){
            if (!Doctors.Contains(doctor)){
                Doctors.Add(doctor);
                doctor.AddPatient(this);
            }
        }
        public void ShowDoctors(){
            Console.WriteLine(Name + " has consulted the following doctors:");
            foreach (var doctor in Doctors){
                Console.WriteLine("- " + doctor.Name);
            }
            Console.WriteLine("*");
        }
    }
    class Doctor{
        public string Name { get; set; }
        public List<Patient> Patients { get; } = new List<Patient>();
        public Doctor(string name){
            Name = name;
        }
        public void AddPatient(Patient patient)
        {
            if (!Patients.Contains(patient))
            {
                Patients.Add(patient);
                patient.ConsultDoctor(this); 
            }
        }
        public void Consult(Patient patient){
            AddPatient(patient);
        }
        public void ShowPatients(){
            Console.WriteLine(Name + " has consulted the following patients:");
            foreach (var patient in Patients){
                Console.WriteLine("- " + patient.Name);
            }
            Console.WriteLine("*");
        }
    }
    class Hospital{
        public string HospitalName { get; set; }
        public List<Doctor> Doctors { get; } = new List<Doctor>();
        public List<Patient> Patients { get; } = new List<Patient>();
        public Hospital(string hospitalName){
            HospitalName = hospitalName;
        }
        public void AddDoctor(Doctor doctor){
            if (!Doctors.Contains(doctor)){
                Doctors.Add(doctor);
            }
        }
        public void AddPatient(Patient patient){
            if (!Patients.Contains(patient)){
                Patients.Add(patient);
            }
        }
        public void ShowDoctors(){
            Console.WriteLine("Doctors in " + HospitalName + ":");
            foreach (var doctor in Doctors){
                Console.WriteLine("- " + doctor.Name);
            }
            Console.WriteLine("*");
        }
        public void ShowPatients(){
            Console.WriteLine("Patients in " + HospitalName + ":");
            foreach (var patient in Patients){
                Console.WriteLine("- " + patient.Name);
            }
            Console.WriteLine("*");
        }
    }
    // Main program
    class main
    {
        public static void Main()
        {
            // Create a hospital instance
            Hospital myHospital = new Hospital("City Hospital");

            // Create doctor instances
            Doctor doctor1 = new Doctor("Doctor1");
            Doctor doctor2 = new Doctor("Doctor2");

            // Create patient instances
            Patient patient1 = new Patient("Patient1");
            Patient patient2 = new Patient("Patient2");

            // Add doctors and patients to the hospital
            myHospital.AddDoctor(doctor1);
            myHospital.AddDoctor(doctor2);
            myHospital.AddPatient(patient1);
            myHospital.AddPatient(patient2);

            // Conduct consultations
            doctor1.Consult(patient1);
            doctor2.Consult(patient2);
            doctor1.Consult(patient2);

            // Display hospital data
            myHospital.ShowDoctors();
            myHospital.ShowPatients();

            // Display doctor-patient relationships
            doctor1.ShowPatients();
            doctor2.ShowPatients();

            patient1.ShowDoctors();
            patient2.ShowDoctors();
        }
    }

}