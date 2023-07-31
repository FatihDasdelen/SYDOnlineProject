using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Model : BaseEntity
    {
        
        public string ModelName { get; set; }
        public int ModelYear { get; set; }
        public string Pack { get; set; }
        public int VehicleID { get; set; }




        //Relational Properties
        public virtual Vehicle Vehicle { get; set; }
        public virtual List<Product> Products { get; set; }
       
    }
}
