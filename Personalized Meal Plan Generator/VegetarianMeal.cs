using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalized_Meal_Plan_Generator
{
    internal class VegetarianMeal : IMealPlan
    {
        public string Name => "Vegetarian Meal";

        public void ShowMeal()
        {
            Console.WriteLine("Vegetarian Meal: Grilled Paneer, Mixed Vegetable Salad, Whole Grain Bread.");
        }
    }
}
