using System;

namespace Assignments
{
    // Base class
    class Course
    {
        public string CourseName { get; set; }
        public int Duration { get; set; } // Duration in weeks

        public Course(string courseName, int duration)
        {
            CourseName = courseName;
            Duration = duration;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks");
        }
    }

    // Subclass: OnlineCourse
    class OnlineCourse : Course
    {
        public string Platform { get; set; }
        public bool IsRecorded { get; set; }

        public OnlineCourse(string courseName, int duration, string platform, bool isRecorded) : base(courseName, duration)
        {
            Platform = platform;
            IsRecorded = isRecorded;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks, Platform: {Platform}, Recorded: {IsRecorded}");
        }
    }

    // Subclass: PaidOnlineCourse
    class PaidOnlineCourse : OnlineCourse
    {
        public double Fee { get; set; }
        public double Discount { get; set; } // Percentage discount

        public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount)
            : base(courseName, duration, platform, isRecorded)
        {
            Fee = fee;
            Discount = discount;
        }

        public override void DisplayInfo()
        {
            double finalFee = Fee - (Fee * (Discount / 100));
            Console.WriteLine($"Course: {CourseName}, Duration: {Duration} weeks, Platform: {Platform}, Recorded: {IsRecorded}, Fee: ${Fee}, Discount: {Discount}%, Final Fee: ${finalFee}");
        }
    }

    class Class7
    {
        public static void Main7()
        {
            Course basicCourse = new Course("Introduction to Programming", 6);
            OnlineCourse onlineCourse = new OnlineCourse("Web Development", 8, "GLA University", true);
            PaidOnlineCourse paidCourse = new PaidOnlineCourse("Advanced C#", 10, "BridgeLabz", true, 280, 17);

            basicCourse.DisplayInfo();
            onlineCourse.DisplayInfo();
            paidCourse.DisplayInfo();
        }
    }
}
