using System;

class BonusCalculationforEmployees
{
    static void Main(string[] args){
        double[] employeeSalaries = new double[10];
        double[] yearsWorkedByEmployees = new double[10];
        double[] bonusAmounts = new double[10];
        double[] updatedSalaries = new double[10];

        double totalBonusAmount = 0;
        double totalOriginalSalaries = 0;
        double totalUpdatedSalaries = 0;

        for (int i = 0; i < 10; i++){
            Console.WriteLine("Enter the salary of employee number " + (i + 1) + ":");
            employeeSalaries[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the years of service of employee number " + (i + 1) + ":");
            yearsWorkedByEmployees[i] = double.Parse(Console.ReadLine());

            if (employeeSalaries[i] < 0 || yearsWorkedByEmployees[i] < 0)
            {
                Console.WriteLine("Invalid input. Please re-enter the data.");
                i--; 
                continue;
            }
        }
        for (int i = 0; i < 10; i++){
            if (yearsWorkedByEmployees[i] > 5)
            {
                bonusAmounts[i] = employeeSalaries[i] * 0.05;
            }
            else
            {
                bonusAmounts[i] = employeeSalaries[i] * 0.02;
            }
            updatedSalaries[i] = employeeSalaries[i] + bonusAmounts[i];
            totalBonusAmount += bonusAmounts[i];
            totalOriginalSalaries += employeeSalaries[i];
            totalUpdatedSalaries += updatedSalaries[i];
        }
        Console.WriteLine("Total bonus amount: " + totalBonusAmount);
        Console.WriteLine("Total original salaries: " + totalOriginalSalaries);
        Console.WriteLine("Total updated salaries: " + totalUpdatedSalaries);
    }
}