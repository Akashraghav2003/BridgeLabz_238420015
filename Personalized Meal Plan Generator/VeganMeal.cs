using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalized_Meal_Plan_Generator
{
    public class VeganMeal : IMealPlan
    {
        public string Name => "Vegan Meal";
        public void ShowMeal()
        {
            Console.WriteLine("Vegan Meal: Quinoa Bowl, Chickpea Salad, Avocado Toast.");
        }
    }
}
