using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fadeev_prac.modelDB
{
    [Table(Name ="Product")]
    class Product
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id_product { get; set; }
        [Column]
        public int id_producer { get; set; }
        [Column]
        public string name_product { get; set; }
        [Column]
        public string aricle_product { get; set; }
        [Column]
        public string type_product { get; set; }
        [Column]
        public int cost_per_product{ get; set; }
    }
}
