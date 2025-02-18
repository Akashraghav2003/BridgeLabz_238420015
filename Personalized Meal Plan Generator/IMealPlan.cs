using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalized_Meal_Plan_Generator
{
    public interface IMealPlan
    {
        public string Name { get; }
        public void ShowMeal();
    }
}
