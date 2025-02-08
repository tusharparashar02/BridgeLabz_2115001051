using System;

namespace Assignments
{
    // Interface for Worker
    interface IWorker
    {
        void PerformDuties();
    }

    // Base class
    class Person1
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Person1(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public virtual void DisplayRole()
        {
            Console.WriteLine("This is a person in the restaurant system.");
        }
    }

    // Subclass: Chef
    class Chef : Person1, IWorker
    {
        public string Specialty { get; set; }

        public Chef(string name, int id, string specialty)
            : base(name, id)
        {
            Specialty = specialty;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Chef - Name: {Name}, ID: {Id}, Specialty: {Specialty}");
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is cooking delicious meals.");
        }
    }

    // Subclass: Waiter
    class Waiter : Person1, IWorker
    {
        public int TablesAssigned { get; set; }

        public Waiter(string name, int id, int tablesAssigned)
            : base(name, id)
        {
            TablesAssigned = tablesAssigned;
        }

        public override void DisplayRole()
        {
            Console.WriteLine($"Waiter - Name: {Name}, ID: {Id}, Tables Assigned: {TablesAssigned}");
        }

        public void PerformDuties()
        {
            Console.WriteLine($"{Name} is serving customers.");
        }
    }

    class Class10
    {
        public static void Main10()
        {
            IWorker chef = new Chef("Chef", 101, "Hello World");
            IWorker waiter = new Waiter("Waiter", 102, 8);

            chef.PerformDuties();
            waiter.PerformDuties();
        }
    }
}
