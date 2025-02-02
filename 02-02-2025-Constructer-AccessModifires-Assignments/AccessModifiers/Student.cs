class Student
{
    public int RollNumber { get; set; }
    protected string Name { get; set; }
    private double CGPA;

    public Student(int rollNumber, string name, double cgpa){
        RollNumber = rollNumber;
        Name = name;
        CGPA = cgpa;
    }
    public double GetCGPA(){
        return CGPA;
    }
    public void SetCGPA(double cgpa){
        CGPA = cgpa;
    }
}

// PostgraduateStudent Class
class PostgraduateStudent : Student
{
    public string ResearchTopic { get; set; }

    public PostgraduateStudent(int rollNumber, string name, double cgpa, string researchTopic)
        : base(rollNumber, name, cgpa)
    {
        ResearchTopic = researchTopic;
    }
}
