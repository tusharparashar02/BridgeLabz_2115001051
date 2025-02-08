using System;

namespace Assignments
{
    // Superclass
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Subclass: Dog
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // Subclass: Cat
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }

    // Subclass: Bird
    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age) { }

        public override void MakeSound()
        {
            Console.WriteLine("Bird chirps");
        }
    }

    class Class1
    {
        public static void Main1()
        {
            Animal myDog = new Dog("Hello", 2);
            Animal myCat = new Cat("World", 5);
            Animal myBird = new Bird("Worldtwo", 9);

            myDog.MakeSound();
            myCat.MakeSound();
            myBird.MakeSound();
        }
    }

}
