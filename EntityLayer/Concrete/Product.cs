using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product:IEntity
    {
        [Key]
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public int CategoryId { get; set; }

        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
       
        public bool isActive { get; set; }
    }
}
