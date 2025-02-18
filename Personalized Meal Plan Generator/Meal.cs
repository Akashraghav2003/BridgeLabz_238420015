using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalized_Meal_Plan_Generator
{
    public class Meal<T> where T : IMealPlan
    {
        private List<T> meals = new List<T>();

        // Method to add meals dynamically
        public void AddMeal(T meal)
        {
            meals.Add(meal);
        }

        // Method to display all added meals
        public void DisplayMeals()
        {
            Console.WriteLine("\nMeal Plan Details:");
            foreach (var meal in meals)
            {
                meal.ShowMeal();
            }
        }
        public static Meal<T> GenerateMealPlan<U>() where U : T, new()
        {
            Meal<T> mealPlan = new Meal<T>();
            U meal = new U();
            mealPlan.AddMeal(meal);
            return mealPlan;
        }
    }
}
