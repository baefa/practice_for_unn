using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fadeev_prac.modelDB
{
    [Table(Name ="Warehouse")]
    class Warehouse
    {
        [Column(IsPrimaryKey =true,IsDbGenerated = true)]
        public int id_warehouse{ get; set; }
        [Column]
        public string name_warehouse { get; set; }
        [Column]
        public string addres_warehouse { get; set; }
    }
}
