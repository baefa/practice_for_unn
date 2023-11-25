using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fadeev_prac.Model
{
    [Table("product_receive")]
    public class ReceiveProduct
    {
        [Key]
        [Column("id_producer_receive")]
        public int id_producer_receive { get; set; }
        
        [Column("quantity_product")]
        [Display(Name = "Quantity of product")]
        public int quantity_product { get; set; }
        
        [Column("date_of_receive")]
        [Display(Name = "Date of receive")]
        public DateTime date_of_receive { get; set; }
        
        
        // supplier - внешний ключ
        [ForeignKey("id_supplier")]
        [Column("id_supplier")]
        public int id_supplier { get; set; }
        public Supplier supplier { get; set; }
        public List<Supplier> suppliers { get; set; }
        
        
        //products - внешний ключ
        [ForeignKey("id_product")]
        [Column("id_product")]
        public int id_product { get; set; }
        public Product product { get; set; }
        public List<Product> products { get; set; }
        
        
        //warehouses - внешний ключ
        [ForeignKey("id_warehouse")]
        [Column("id_warehouse")]
        public int id_warehouse { get; set; }
        public Warehouse warehouse { get; set; }
        public List<Warehouse> warehouses { get; set; }
    }
}
