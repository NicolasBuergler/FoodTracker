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
        private static async Task SaveData(string data)
        {
            var path = FileSystem.Current.AppDataDirectory;
            var fullPath = Path.Combine(path, "SaveFile.txt");

            File.AppendAllText(fullPath, data);
            //File.WriteAllText(fullPath, data);
        }

        private static async Task<string> LoadData()
        {
            var path = FileSystem.Current.AppDataDirectory;
            var fullPath = Path.Combine(path, "SaveFile.txt");

            var content = File.ReadAllText(fullPath);
            return content;
        }

        public async static Task<Food> AddFood(string barcode)
        {
            FoodType foodType = await OpenFoodApiService.GetFoodTypeByBarcode(barcode);
            Food newFood = new Food()
            {
                Type = foodType,
                EatingDateTime = DateTime.Now
            };

            await SaveData($"{newFood.Type.Code},{newFood.EatingDateTime};");
            return newFood;
        }

        public async static Task<List<Food>> GetFoods() 
        {
            var content = await LoadData();
            var foodProductStrings = content.Split(';');

            var foodProducts = new List<Food>();
            foreach ( var foodProduct in foodProductStrings)
            {
                if(string.IsNullOrEmpty(foodProduct)) 
                    continue;

                var barcode = foodProduct.Split(",")[0].Trim();
                var dateTimeString = foodProduct.Split(",")[1];

                var foodType = await OpenFoodApiService.GetFoodTypeByBarcode(barcode);
                var dateTime = Convert.ToDateTime(dateTimeString);

                foodProducts.Add(new Food() {Type = foodType, EatingDateTime = dateTime});
            }

            return foodProducts;
            
        }
    }
}
