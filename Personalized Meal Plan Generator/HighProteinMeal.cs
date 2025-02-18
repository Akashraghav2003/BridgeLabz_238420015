using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalized_Meal_Plan_Generator
{
    public class HighProteinMeal : IMealPlan
    {
        public string Name => "High-Protein Meal";
        public void ShowMeal()
        {
            Console.WriteLine("High-Protein Meal: Salmon, Boiled Eggs, Greek Yogurt.");
        }
    }
}
