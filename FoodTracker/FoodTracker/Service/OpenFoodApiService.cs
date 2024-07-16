using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodTracker.Models;
using Newtonsoft.Json;

namespace FoodTracker.Service
{
    public static class OpenFoodApiService
    {
        static HttpClient client = new HttpClient();
        private static async Task<string> GetApiData(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }

        public async static Task<FoodType> GetFoodTypeByBarcode(int Barcode)
        {
            string url = $"https://world.openfoodfacts.org/api/v2/product/5449000214911";
            string response = await GetApiData(url);

            FoodType foodType = JsonConvert.DeserializeObject<FoodType>(response);
            return foodType;
        }
    }
}
