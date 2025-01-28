using System;

public class StudentVoteChecker
{
    public static bool CanStudentVote(int age){
        if (age < 0){
            return false;
        }
        return age >= 18;
    }
    public static void Main(){
        int[] ages = new int[10];
        for (int i = 0; i < 10; i++){
            Console.WriteLine("Enter the age of student " + (i + 1) + ": ");
            ages[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < 10; i++){
            Console.WriteLine("Student " + (i + 1) + " can vote: " + CanStudentVote(ages[i]));
        }
    }
}
