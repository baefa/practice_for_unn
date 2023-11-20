using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fadeev_prac.modelDB
{
    [Table(Name = "RecieveProduct")]
    class RecieveProduct
    {
        [Column(IsPrimaryKey = true,IsDbGenerated = true)]
        public int id_producer { get; set; }
        [Column]
        public int id_supplier { get; set; }
        [Column]
        public int id_product { get; set; }
        [Column]
        public int id_warehouse { get; set; }
        [Column]
        public int quantity_product { get; set; }
        [Column]
        public DateTime date_of_receive { get; set; }
    }
}
