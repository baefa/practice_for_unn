using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fadeev_prac.Model
{
    [Table("product")]
    public class Product
    {
        [Key] 
        [Column("id_product")] 
        public int id_product { get; set; }

        [Column("name_product")]
        [Display(Name = "Product Name")]
        public string name { get; set; }

        [Column("article_product")]
        [Display(Name = "Product Article")]
        public string article { get; set; }

        [Column("type_product")]
        [Display(Name = "Product Type")]
        public string type { get; set; }

        [Column("cost_per_product")]
        [Display(Name = "Cost")]
        public int cost { get; set; }
        
        
        // producer - внешний ключ
        [ForeignKey("id_producer")]
        [Column("Id_producer")]
        public int id_producer { get; set; }
        public Producer producer { get; set; }
        
        // receive of product - для отношения многие-ко-многим
        public List<ReceiveProduct> receiveProducts { get; set; }
    }
}