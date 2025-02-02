class Course
{
    public string CourseName { get; set; }
    public int Duration { get; set; }
    public double Fee { get; set; }
    private static string InstituteName = "GLA Institute";

    // Constructor
    public Course(string courseName, int duration, double fee)
    {
        CourseName = courseName;
        Duration = duration;
        Fee = fee;
    }

    // Instance Method to Display Course Details
    public void DisplayCourseDetails()
    {
        Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks, Fee: ${Fee}, Institute: {InstituteName}");
    }

    // Class Method to Update Institute Name
    public static void UpdateInstituteName(string newInstituteName)
    {
        InstituteName = newInstituteName;
    }
}