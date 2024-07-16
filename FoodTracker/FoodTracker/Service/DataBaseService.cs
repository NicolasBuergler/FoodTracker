using FoodTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.Net.Maui;

namespace FoodTracker.Service
{
    public static class DataBaseService
    {
        public async static void AddFood(string barcode)
        {
            FoodType foodType = await OpenFoodApiService.GetFoodTypeByBarcode(barcode);
            Food newFood = new Food()
            {
                Type = foodType,
                EatingDateTime = DateTime.Now
            };
        }

        public static List<Food> GetFoods() 
        {
            return new List<Food>();
        }
    }
}
