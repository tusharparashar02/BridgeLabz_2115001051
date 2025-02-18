using System;
using System.Collections.Generic;
using System.Linq;

// 1. Base class for job roles
public abstract class JobRole
{
    public string CandidateName;
    public List<string> Skills;

    public JobRole(string name, List<string> skills)
    {
        CandidateName = name;
        Skills = skills;
    }

    public abstract bool IsEligible();
}

// 2. Software Engineer Role
public class SoftwareEngineer : JobRole
{
    private static List<string> RequiredSkills = new List<string> { "C#", ".NET", "SQL Server", "MERN" };

    public SoftwareEngineer(string name, List<string> skills) : base(name, skills) { }

    public override bool IsEligible()
    {
        return RequiredSkills.All(skill => Skills.Contains(skill));
    }
}

// 3. Data Scientist Role
public class DataScientist : JobRole
{
    private static List<string> RequiredSkills = new List<string> { "Python", "Machine Learning", "Statistics", "SQL" };

    public DataScientist(string name, List<string> skills) : base(name, skills) { }

    public override bool IsEligible()
    {
        return RequiredSkills.All(skill => Skills.Contains(skill));
    }
}

// 4. Generic Resume Class
public class Resume<T> where T : JobRole
{
    private List<T> candidates = new List<T>();

    public void AddCandidate(T candidate)
    {
        candidates.Add(candidate);
        Console.WriteLine(candidate.CandidateName + " applied for " + typeof(T).Name);
    }

    public void DisplayAllCandidates()
    {
        Console.WriteLine("All candidates for " + typeof(T).Name + ":");
        foreach (var candidate in candidates)
        {
            Console.WriteLine(candidate.CandidateName + "Skills: " + string.Join(", ", candidate.Skills));
        }
    }

    public void DisplayEligibleCandidates()
    {
        Console.WriteLine("Eligible candidates for " + typeof(T).Name + ":");
        foreach (var candidate in candidates.Where(c => c.IsEligible()))
        {
            Console.WriteLine(candidate.CandidateName + " is eligible.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Resume<SoftwareEngineer> softwareEngineerResumes = new Resume<SoftwareEngineer>();
        Resume<DataScientist> dataScientistResumes = new Resume<DataScientist>();

        // Add candidates for Software Engineer
        softwareEngineerResumes.AddCandidate(new SoftwareEngineer("Tushar", new List<string> { "C#", ".NET", "SQL Server", "MERN" }));
        softwareEngineerResumes.AddCandidate(new SoftwareEngineer("Parashar", new List<string> { "Java", "Spring", "SQL" }));

        // Add candidates for Data Scientist
        dataScientistResumes.AddCandidate(new DataScientist("Tushar", new List<string> { "Python", "Machine Learning", "Statistics", "SQL" }));
        dataScientistResumes.AddCandidate(new DataScientist("Parashar", new List<string> { "Python", "Data Visualization" }));

        // Display all and eligible candidates
        softwareEngineerResumes.DisplayAllCandidates();
        softwareEngineerResumes.DisplayEligibleCandidates();

        dataScientistResumes.DisplayAllCandidates();
        dataScientistResumes.DisplayEligibleCandidates();
    }
}
