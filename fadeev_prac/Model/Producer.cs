using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace fadeev_prac.Model
{
    [Table("producer")]
    public class Producer
    {
        [Key]
        [Column("id_producer")]
        public int id_producer { get; set; }
        
        [Display(Name = "Producer Name")]
        [Column("name_producer")]
        public string name_producer { get; set; }
        
        [Display(Name = "Producer Addres")]
        [Column("addres_producer")]
        public string addres_producer { get; set; }
        
        [Display(Name = "Producer Telephone")]
        [Column("telephone_producer")]
        public string telephone_producer { get; set; }
        
        [Display(Name = "Producer bank details")]
        [Column("bank_details_producer")]
        public string bank_details_producer { get; set; }
        
        // products - для отношения многие-ко-многим
        public ICollection<Product> products { get; set; }
    }
}
