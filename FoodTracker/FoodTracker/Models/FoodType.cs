using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FoodTracker.Models
{
    public class Nutriments
    {
        [JsonProperty("carbohydrates_value")]
        /// <summary>
        /// Einheit: Gramm
        /// </summary> 
        public float Carbohydrates {  get; set; }

        [JsonProperty("energy-kcal_value")]
        /// <summary>
        /// Einheit: Kilokalorie
        /// </summary>
        public float Energy { get; set; }

        [JsonProperty("fat_value")]
        /// <summary>
        /// Einheit: Gramm
        /// </summary>
        public float Fat { get; set; }

        [JsonProperty("proteins_value")]
        /// <summary>
        /// Einheit: Gramm
        /// </summary>
        public float Proteins { get; set; }

        [JsonProperty("salt_value")]
        /// <summary>
        /// Einheit: Gramm
        /// </summary>
        public float Salt { get; set; }

        [JsonProperty("sugars_value")]
        /// <summary>
        /// Einheit: Gramm
        /// </summary>
        public float Sugar { get; set; }
    }



    public class Product
    {
        [JsonProperty("nutriments")]
        public Nutriments Nutriments { get; set; }

        [JsonProperty("image_front_url")]
        public string imagelink { get; set; }

        [JsonProperty("generic_name")]
        public string Name { get; set; }
    }

    public class FoodType
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("product")]
        public Product Product { get; set; }
    }
}
