using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fadeev_prac.modelDB
{
    [Table(Name = "Supplier")]
    class Supplier
    {
        [Column(IsPrimaryKey =true, IsDbGenerated = true)]
        public int id_supplier { get; set; }
        [Column]
        public string name_supplier { get; set; }
        [Column]
        public string addres_supplier { get; set; }
        [Column]
        public string telephone_supplier { get; set; }
        [Column]
        public string bank_details_supplier { get; set; }
    }
}
