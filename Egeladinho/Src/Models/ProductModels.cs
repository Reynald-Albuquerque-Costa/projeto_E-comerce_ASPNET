using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Egeladinho.Src.Models
{
    [Table ("tb_products")]
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id  { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Quantity { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }
        
        [JsonIgnore, InverseProperty("Product")]
        public List<Cart> Carts { get; set; }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Category
    {
        FRUTAS,
        LEITE,
        VEGANO,
        INFANTIL
    }
} 