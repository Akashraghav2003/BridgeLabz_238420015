using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalized_Meal_Plan_Generator
{
    public class KetoMeal : IMealPlan
    {
        public string Name => "Keto Meal";
        public void ShowMeal()
        {
            Console.WriteLine("Keto Meal: Grilled Chicken, Cauliflower Rice, Avocado.");
        }
    }
}
