using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MountainMealTime.Models;

namespace MountainMealTime.Models
{
    public class Meal
    {
        public Dictionary<string, string> meals = new Dictionary<string, string>()
        {
            {"6:50:00 AM", "Bcca, Glutamine, and a handful of Almonds." },
            {"7:30:00 AM", "8 Eggs, 200 grams of Oats, Blueberries, Strawberries, and an Avocado." },
            {"9:30:00 AM", "400 grams of Beef, 400 grams of Sweet Potatoes, and a handful of Spinach and Greens." },
            {"11:50:00 AM", "Bcca and Glutamine." },
            {"12:00:00 PM", "400 grams of Chicken, 400 grams of Potatoes, some Greens, and some Fruit." },
            {"2:00:00 PM", "BLEND: 150 grams of Oats or Sweet Potatoes, 2 Bananas, 150 grams of Rice Krispies, Frozen Berries, a handful of Almonds, Peanut Butter, and Glutamine." },
            {"2:30:00 PM", "Bcca, Glutamine, Vitargo." },
            {"5:30:00 PM", "60 grams of Protein and 2 Bananas." },
            {"6:00:00 PM", "500 grams of Beef, Potatoes, and Greens." },
            {"8:30:00 PM", "500 grams of Salmon and 500 grams of Sweet Potatoes." },
            {"10:30:00 PM", "50 grams of Casein Protein." }
        };
    }
}