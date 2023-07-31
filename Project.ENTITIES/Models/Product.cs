using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Product : BaseEntity
    {

        
        public string ProductName { get; set; }
       
        public string PartCode { get; set; }

        public short UnitsInStock { get; set; }

        
        public decimal UnitPrice { get; set; }
        public string ImagePath { get; set; }
        public int CategoryID { get; set; }
        public int? ModelID { get; set; }



        //Relational Properties
        public virtual Category Category { get; set; }
        
        public virtual List<OrderDetail> OrderDetails { get; set; }
        public virtual Model Model { get; set; }
    }
}
