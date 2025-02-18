using System;
using System.Collections.Generic;

// 1. Define an interface for meal plans
public interface IMealPlan
{
    string MealName { get; }
    int Calories { get; }
    void DisplayMeal();
}

// 2. Define specific meal types implementing IMealPlan

// Vegetarian Meal
public class VegetarianMeal : IMealPlan
{
    public string MealName { get; private set; }
    public int Calories { get; private set; }

    public VegetarianMeal(string name, int calories)
    {
        MealName = name;
        Calories = calories;
    }

    public void DisplayMeal()
    {
        Console.WriteLine("[Vegetarian] " + MealName + "Calories: " + Calories);
    }
}

// Vegan Meal
public class VeganMeal : IMealPlan
{
    public string MealName { get; private set; }
    public int Calories { get; private set; }

    public VeganMeal(string name, int calories)
    {
        MealName = name;
        Calories = calories;
    }

    public void DisplayMeal()
    {
        Console.WriteLine("[Vegan] " + MealName + "Calories: " + Calories);
    }
}

// Keto Meal
public class KetoMeal : IMealPlan
{
    public string MealName { get; private set; }
    public int Calories { get; private set; }

    public KetoMeal(string name, int calories)
    {
        MealName = name;
        Calories = calories;
    }

    public void DisplayMeal()
    {
        Console.WriteLine("[Keto] " + MealName + "Calories: " + Calories);
    }
}

// High Protein Meal
public class HighProteinMeal : IMealPlan
{
    public string MealName { get; private set; }
    public int Calories { get; private set; }

    public HighProteinMeal(string name, int calories)
    {
        MealName = name;
        Calories = calories;
    }

    public void DisplayMeal()
    {
        Console.WriteLine("[High Protein] " + MealName + "Calories: " + Calories);
    }
}

// 3. Generic class to manage meal plans
public class Meal<T> where T : IMealPlan
{
    private List<T> meals = new List<T>();

    public void AddMeal(T meal)
    {
        meals.Add(meal);
        Console.WriteLine(meal.MealName + " added to the meal plan.");
    }

    public void DisplayMeals()
    {
        Console.WriteLine("Meal Plan:");
        foreach (var meal in meals)
        {
            meal.DisplayMeal();
        }
    }
}

// 4. Generic method to generate a meal plan dynamically
public static class MealPlanGenerator
{
    public static void GenerateMealPlan<T>(Meal<T> mealPlan, T meal) where T : IMealPlan
    {
        mealPlan.AddMeal(meal);
        Console.WriteLine(meal.MealName + " has been successfully added to your meal plan.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Meal<VegetarianMeal> vegetarianPlan = new Meal<VegetarianMeal>();
        Meal<VeganMeal> veganPlan = new Meal<VeganMeal>();
        Meal<KetoMeal> ketoPlan = new Meal<KetoMeal>();
        Meal<HighProteinMeal> highProteinPlan = new Meal<HighProteinMeal>();

        // Create meal instances
        VegetarianMeal vegMeal1 = new VegetarianMeal("Panner", 300);
        VeganMeal veganMeal1 = new VeganMeal("Salad", 300);
        KetoMeal ketoMeal1 = new KetoMeal("Avocado", 400);
        HighProteinMeal highProteinMeal1 = new HighProteinMeal("Chicken", 400);

        // Generate meal plans dynamically
        MealPlanGenerator.GenerateMealPlan(vegetarianPlan, vegMeal1);
        MealPlanGenerator.GenerateMealPlan(veganPlan, veganMeal1);
        MealPlanGenerator.GenerateMealPlan(ketoPlan, ketoMeal1);
        MealPlanGenerator.GenerateMealPlan(highProteinPlan, highProteinMeal1);

        // Display all meal plans
        vegetarianPlan.DisplayMeals();
        veganPlan.DisplayMeals();
        ketoPlan.DisplayMeals();
        highProteinPlan.DisplayMeals();
    }
}
