using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            var ingredients = Console.ReadLine();
            var Break = "Bake!";
            var times = 0;
            while (ingredients !=  Break)
            {
                Console.WriteLine($"Adding ingredient {ingredients}.");
                times++;
                ingredients = Console.ReadLine();                
            }
            Console.WriteLine($"Preparing cake with {times} ingredients.");
        }
    }
}
