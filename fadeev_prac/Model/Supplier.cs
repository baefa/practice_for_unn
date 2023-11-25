using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fadeev_prac.Model
{
    [Table("supplier")]
    public class Supplier
    {
        [Key]
        [Column("")]
        public int id_supplier { get; set; }
        
        [Column("name_supplier")]
        [Display(Name = "Supplier name")]
        public string name_supplier { get; set; }
        
        [Column("addres_supplier")]
        [Display(Name = "Supplier addres")]
        public string addres_supplier { get; set; }
        
        [Column("telephone_supplier")]
        [Display(Name = "Supplier telephone")]
        public string telephone_supplier { get; set; }
        
        [Column("bank_details_supplier")]
        [Display(Name = "Supplier bank details")]
        public string bank_details_supplier { get; set; }
        
        // receive of product - для отношения многие-ко-многим
        public List<ReceiveProduct> receiveProducts { get; set; }
    }
}
