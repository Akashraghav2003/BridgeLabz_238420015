using Personalized_Meal_Plan_Generator;
class Program
{
    static void Main()
    {
        // Vegetarian Meal Plan
        Meal<VegetarianMeal> vegetarianMealPlan = Meal<VegetarianMeal>.GenerateMealPlan<VegetarianMeal>();
        vegetarianMealPlan.DisplayMeals();

        // Vegan Meal Plan
        Meal<VeganMeal> veganMealPlan = Meal<VeganMeal>.GenerateMealPlan<VeganMeal>();
        veganMealPlan.DisplayMeals();

        // Keto Meal Plan
        Meal<KetoMeal> ketoMealPlan = Meal<KetoMeal>.GenerateMealPlan<KetoMeal>();
        ketoMealPlan.DisplayMeals();

        // High-Protein Meal Plan
        Meal<HighProteinMeal> highProteinMealPlan = Meal<HighProteinMeal>.GenerateMealPlan<HighProteinMeal>();
        highProteinMealPlan.DisplayMeals();
    }
}