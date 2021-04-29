using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerce.Models
{
    public class Products
    {
        [JsonProperty("Id")]

        public int Id { get; set; }

        [JsonProperty("Name")]

        [Required]
        public string Name { get; set; }


        [Required]
        [JsonProperty("Price")]

        public decimal Price { get; set; }

        [JsonProperty("Image")]

        public string Image { get; set; }

        [JsonProperty("ProductColor")]

        [Display(Name = "Product Color")]
        public string ProductColor { get; set; }

        [JsonProperty("IsAvailable")]

        [Required]
        [Display(Name = "Available")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Product Type")]
        [Required]
        [JsonProperty("ProductTypeId")]

        public int ProductTypeId { get; set; }


        [JsonProperty("ProductTypes")]
        [ForeignKey("ProductTypeId")]
        public ProductTypes ProductTypes { get; set; }



    }
}
