using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fadeev_prac.Model
{
    [Table("warehouse")]
    public class Warehouse
    {
        [Key]
        [Column("id_warehouse")]
        public int id_warehouse{ get; set; }
        
        [Column("")]
        [Display(Name = "Warehouse name")]
        public string name_warehouse { get; set; }
        
        [Column("")]
        [Display(Name = "Warehouse addres")]
        public string addres_warehouse { get; set; }
        
        // receive of product - для отношения многие-ко-многим
        public List<ReceiveProduct> receiveProducts { get; set; }
    }
}
