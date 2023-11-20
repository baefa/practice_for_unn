using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fadeev_prac.modelDB
{
    [Table(Name = "Producer")]
    class Producer
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int id_producer { get; set; }
        [Column]
        public string name_producer { get; set; }
        [Column]
        public string addres_producer { get; set; }
        [Column]
        public string telephone_producer { get; set; }
        [Column]
        public string bank_details_producer { get; set; }
    }
}
