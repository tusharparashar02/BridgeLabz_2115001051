class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Person(string name, int age){
        Name = name;
        Age = age;
    }

    // Copy Constructor
    public Person(Person other){
        Name = other.Name;
        Age = other.Age;
    }
}